/*
 * Program Name: MTranQGame
 * 
 * Purpose: To create a functioning Q-Puzzle game
 * 
 * Revision History:
 *      created by Maria Tran on Nov 06, 2021
 *      edited by Maria Tran on Nov 07, 2021
 *      edited by Maria Tran on Nov 13, 2021
 *      edited by Maria Tran on Nov 17, 2021
 *      edited by Maria Tran on Nov 20, 2021
 *      edited by Maria Tran on Nov 21, 2021
 *      edited by Maria Tran on Nov 25, 2021
 *      edited by Maria Tran on Mar 05, 2022
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MTranQGame
{
    /// <summary>
    /// The class for the Game Field
    /// </summary>
    public partial class GameField : Form
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public GameField()
        {
            InitializeComponent();
        }

        ///Global Variables
        public bool gameOpen = false;
        static StreamReader reader;
        private const int LEFT = 25;
        private const int TOP = 23;
        private const int WIDTH = 75;
        private const int HEIGHT = 75;
        private const int NULL = 0;
        private const int WALL = 1;
        private const int BLUE_DOOR = 2;
        private const int PURPLE_DOOR = 3;
        private const int BLUE_ICON = 6;
        private const int PURPLE_ICON = 7;
        List<PictureBox> boxList = new List<PictureBox>();
        Image wall = MTranQGame.Properties.Resources.wall;
        Image blueDoor = MTranQGame.Properties.Resources.bluedoor;
        Image purpleDoor = MTranQGame.Properties.Resources.purpledoor;
        Image blueIcon = MTranQGame.Properties.Resources.blueicon;
        Image purpleIcon = MTranQGame.Properties.Resources.purpleicon;
        int countMoves = 0;
        int remainingBoxes = 0;
        public bool selectedBox = false;
        PictureBox pbHere;
        int[,] pbArray;
        public int arrayRow;
        public int arrayColumn;

        /// <summary>
        /// This closes the game field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// This loads the game field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dialogOpen.InitialDirectory = "c:\\";
                dialogOpen.Filter = "Text file|*.txt|All files|*.*";
                DialogResult r = dialogOpen.ShowDialog();

                switch (r)
                {
                    case DialogResult.None:
                        break;
                    case DialogResult.OK:
                        string fileName = dialogOpen.FileName;
                        load(fileName);

                        if (gameOpen == true)
                        {
                            btnUp.Enabled = true;
                            btnDown.Enabled = true;
                            btnLeft.Enabled = true;
                            btnRight.Enabled = true;

                            txtNumOfMoves.Text = countMoves.ToString();
                            txtRemainingIcons.Text = remainingBoxes.ToString();
                        }
                        break;
                    case DialogResult.Cancel:
                        break;
                    case DialogResult.Abort:
                        break;
                    case DialogResult.Retry:
                        break;
                    case DialogResult.Ignore:
                        break;
                    case DialogResult.Yes:
                        break;
                    case DialogResult.No:
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error in loading the game: " + ex.Message);
            }
        }

        /// <summary>
        /// This will open the file
        /// </summary>
        /// <param name="fileName"></param>
        private void load(string fileName)
        {
            try
            {
                clearGame();
                int row = 0;
                int column = 0;
                int x = LEFT;
                int y = TOP;
                Size size = new Size(WIDTH, HEIGHT);

                using (reader = new StreamReader(fileName))
                {
                    while (!reader.EndOfStream)
                    {
                        row = int.Parse(reader.ReadLine());
                        column = int.Parse(reader.ReadLine());
                        int totalBoxes = row * column;
                        pbArray = new int[row, column];

                        for (int i = 0; i < totalBoxes; i++)
                        {
                            int arrayRow = int.Parse(reader.ReadLine());
                            int arrayColumn = int.Parse(reader.ReadLine());
                            int arrayType = int.Parse(reader.ReadLine());

                            pbArray[arrayRow, arrayColumn] = arrayType;

                            int currentColumn = i % column;
                            int currentRow = i / column;
                            int currentX = x + currentColumn * WIDTH;
                            int currentY = y + currentRow * HEIGHT;

                            if (arrayType != NULL)
                            {
                                PictureBox pb = new PictureBox
                                {
                                    Size = size,
                                    Location = new Point(currentX, currentY),
                                    SizeMode = PictureBoxSizeMode.StretchImage,
                                    Name = arrayRow + "\t" + arrayColumn,
                                    Tag = arrayType
                                };

                                picImage(pb);

                                if (pb.Image == blueIcon || pb.Image == purpleIcon)
                                {
                                    pb.Click += pb_Click;
                                    remainingBoxes++;
                                }

                                panelGame.Controls.Add(pb);
                                boxList.Add(pb);
                            }
                        }
                    }
                }
                arrayRow = row;
                arrayColumn = column;
                gameOpen = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in reading the file: " + ex.Message);
                gameOpen = false;
            }
        }

        /// <summary>
        /// This will allow the user to choose which icon to move
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pb_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;

            foreach (PictureBox checkPic in boxList)
            {
                checkPic.BorderStyle = BorderStyle.None;
            }

            pic.BorderStyle = BorderStyle.FixedSingle;
            selectedBox = true;
            pbHere = pic;
        }

        /// <summary>
        /// This will load the images in the Game Field
        /// </summary>
        /// <param name="picImage"></param>
        private void picImage(PictureBox picImage)
        {
            if ((int)picImage.Tag == WALL)
            {
                picImage.Image = wall;
            }
            if ((int)picImage.Tag == BLUE_DOOR)
            {
                picImage.Image = blueDoor;
            }
            if ((int)picImage.Tag == PURPLE_DOOR)
            {
                picImage.Image = purpleDoor;
            }
            if ((int)picImage.Tag == BLUE_ICON)
            {
                picImage.Image = blueIcon;
            }
            if ((int)picImage.Tag == PURPLE_ICON)
            {
                picImage.Image = purpleIcon;
            }
        }

        /// <summary>
        /// This will check if the player won the game
        /// </summary>
        private void didWin()
        {
            if (remainingBoxes == 0)
            {
                clearGame();
                MessageBox.Show("Congratulations you won!", "Winner!", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// This will clear the game
        /// </summary>
        private void clearGame()
        {
            panelGame.Controls.Clear();
            gameOpen = false;
            countMoves = 0;
            remainingBoxes = 0;
            selectedBox = false;
            boxList.Clear();
            txtNumOfMoves.Text = "0";
            txtRemainingIcons.Text = "0";
            btnUp.Enabled = false;
            btnDown.Enabled = false;
            btnLeft.Enabled = false;
            btnRight.Enabled = false;
            if (pbArray != null)
            {
                Array.Clear(pbArray, 0, pbArray.Length);
            }
            arrayRow = 0;
            arrayColumn = 0;
        }

        /// <summary>
        /// This will move the icon up
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUp_Click(object sender, EventArgs e)
        {
            if (selectedBox == true)
            {
                PictureBox thisPB = pbHere;
                bool checking = true;
                int move = HEIGHT;

                countMoves++;
                txtNumOfMoves.Text = countMoves.ToString();

                while (checking == true)
                {
                    foreach (PictureBox check in panelGame.Controls)
                    {
                        if (thisPB.Right == check.Right && thisPB.Left == check.Left && thisPB.Top == check.Bottom)
                        {
                            if (check.Image == wall)
                            {
                                checking = false;
                            }
                            else if (check.Image == blueDoor)
                            {
                                if (thisPB.Image == blueIcon)
                                {
                                    thisPB.SendToBack();
                                    panelGame.Controls.Remove(thisPB);
                                    thisPB.Dispose();
                                    selectedBox = false;
                                    remainingBoxes--;
                                    txtRemainingIcons.Text = remainingBoxes.ToString();
                                    checking = false;
                                }
                                else
                                {
                                    checking = false;
                                }
                            }
                            else if (check.Image == purpleDoor)
                            {
                                if (thisPB.Image == purpleIcon)
                                {
                                    thisPB.SendToBack();
                                    panelGame.Controls.Remove(thisPB);
                                    thisPB.Dispose();
                                    selectedBox = false;
                                    remainingBoxes--;
                                    txtRemainingIcons.Text = remainingBoxes.ToString();
                                    checking = false;
                                }
                                else
                                {
                                    checking = false;
                                }
                            }
                            else if (check.Image == blueIcon)
                            {
                                if (thisPB.Image == purpleIcon)
                                {
                                    checking = false;
                                }
                                else if (thisPB.Image == blueIcon)
                                {
                                    checking = false;
                                }
                            }
                            else if (check.Image == purpleIcon)
                            {
                                if (thisPB.Image == blueIcon)
                                {
                                    checking = false;
                                }
                                else if (thisPB.Image == purpleIcon)
                                {
                                    checking = false;
                                }
                            }
                        }

                    }
                    if (checking == true)
                    {
                        thisPB.BringToFront();
                        thisPB.Top -= move;
                    }
                }
                didWin();
            }
            else if (selectedBox == false)
            {
                MessageBox.Show("Please select an icon first", "QGame", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Thids will move the icon down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDown_Click(object sender, EventArgs e)
        {
            if (selectedBox == true)
            {
                PictureBox thisPB = pbHere;
                int move = HEIGHT;
                bool checking = true;

                countMoves++;
                txtNumOfMoves.Text = countMoves.ToString();

                while (checking == true)
                {
                    foreach (PictureBox check in panelGame.Controls)
                    {
                        if (thisPB.Right == check.Right && thisPB.Left == check.Left && thisPB.Bottom == check.Top)
                        {
                            if (check.Image == wall)
                            {
                                checking = false;
                            }
                            else if (check.Image == blueDoor)
                            {
                                if (thisPB.Image == blueIcon)
                                {
                                    thisPB.SendToBack();
                                    panelGame.Controls.Remove(thisPB);
                                    thisPB.Dispose();
                                    selectedBox = false;
                                    remainingBoxes--;
                                    txtRemainingIcons.Text = remainingBoxes.ToString();
                                    checking = false;
                                }
                                else
                                {
                                    checking = false;
                                }
                            }
                            else if (check.Image == purpleDoor)
                            {
                                if (thisPB.Image == purpleIcon)
                                {
                                    thisPB.SendToBack();
                                    panelGame.Controls.Remove(thisPB);
                                    thisPB.Dispose();
                                    selectedBox = false;
                                    remainingBoxes--;
                                    txtRemainingIcons.Text = remainingBoxes.ToString();
                                    checking = false;
                                }
                                else
                                {
                                    checking = false;
                                }
                            }
                            else if (check.Image == blueIcon)
                            {
                                if (thisPB.Image == purpleIcon)
                                {
                                    checking = false;
                                }
                                else if (thisPB.Image == blueIcon)
                                {
                                    checking = false;
                                }
                            }
                            else if (check.Image == purpleIcon)
                            {
                                if (thisPB.Image == blueIcon)
                                {
                                    checking = false;
                                }
                                else if (thisPB.Image == purpleIcon)
                                {
                                    checking = false;
                                }
                            }
                        }
                        
                    }
                    if (checking == true)
                    {
                        thisPB.BringToFront();
                        thisPB.Top += move;
                    }

                }
                didWin();
            }
            else if (selectedBox == false)
            {
                MessageBox.Show("Please select an icon first", "QGame", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// This will move the icon left
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (selectedBox == true)
            {
                PictureBox thisPB = pbHere;
                int move = WIDTH;
                bool checking = true;

                countMoves++;
                txtNumOfMoves.Text = countMoves.ToString();

                while (checking == true)
                {
                    foreach (PictureBox check in panelGame.Controls)
                    {
                        if (thisPB.Bottom == check.Bottom && thisPB.Top == check.Top && thisPB.Left == check.Right)
                        {
                            if (check.Image == wall)
                            {
                                checking = false;
                            }
                            else if (check.Image == blueDoor)
                            {
                                if (thisPB.Image == blueIcon)
                                {
                                    thisPB.SendToBack();
                                    panelGame.Controls.Remove(thisPB);
                                    thisPB.Dispose();
                                    selectedBox = false;
                                    remainingBoxes--;
                                    txtRemainingIcons.Text = remainingBoxes.ToString();
                                    checking = false;
                                }
                                else
                                {
                                    checking = false;
                                }
                            }
                            else if (check.Image == purpleDoor)
                            {
                                if (thisPB.Image == purpleIcon)
                                {
                                    thisPB.SendToBack();
                                    panelGame.Controls.Remove(thisPB);
                                    thisPB.Dispose();
                                    selectedBox = false;
                                    remainingBoxes--;
                                    txtRemainingIcons.Text = remainingBoxes.ToString();
                                    checking = false;
                                }
                                else
                                {
                                    checking = false;
                                }
                            }
                            else if (check.Image == blueIcon)
                            {
                                if (thisPB.Image == purpleIcon)
                                {
                                    checking = false;
                                }
                                else if (thisPB.Image == blueIcon)
                                {
                                    checking = false;
                                }
                            }
                            else if (check.Image == purpleIcon)
                            {
                                if (thisPB.Image == blueIcon)
                                {
                                    checking = false;
                                }
                                else if (thisPB.Image == purpleIcon)
                                {
                                    checking = false;
                                }
                            } 
                        }
                    }
                    if (checking == true)
                    {
                        thisPB.BringToFront();
                        thisPB.Left -= move;
                    }
                }
                didWin();
            }
            else if (selectedBox == false)
            {
                MessageBox.Show("Please select an icon first", "QGame", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// This will move the icon right
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRight_Click(object sender, EventArgs e)
        {
            if (selectedBox == true)
            {
                PictureBox thisPB = pbHere;
                int move = WIDTH;
                bool checking = true;

                countMoves++;
                txtNumOfMoves.Text = countMoves.ToString();

                while (checking == true)
                {
                    foreach (PictureBox check in panelGame.Controls)
                    {
                        if (thisPB.Bottom == check.Bottom && thisPB.Top == check.Top && thisPB.Right == check.Left)
                        {
                            if (check.Image == wall)
                            {
                                checking = false;
                            }
                            else if (check.Image == blueDoor)
                            {
                                if (thisPB.Image == blueIcon)
                                {
                                    thisPB.SendToBack();
                                    panelGame.Controls.Remove(thisPB);
                                    thisPB.Dispose();
                                    selectedBox = false;
                                    remainingBoxes--;
                                    txtRemainingIcons.Text = remainingBoxes.ToString();
                                    checking = false;
                                }
                                else
                                {
                                    checking = false;
                                }
                            }
                            else if (check.Image == purpleDoor)
                            {
                                if (thisPB.Image == purpleIcon)
                                {
                                    thisPB.SendToBack();
                                    panelGame.Controls.Remove(thisPB);
                                    thisPB.Dispose();
                                    selectedBox = false;
                                    remainingBoxes--;
                                    txtRemainingIcons.Text = remainingBoxes.ToString();
                                    checking = false;
                                }
                                else
                                {
                                    checking = false;
                                }
                            }
                            else if (check.Image == blueIcon)
                            {
                                if (thisPB.Image == purpleIcon)
                                {
                                    checking = false;
                                }
                                else if (thisPB.Image == blueIcon)
                                {
                                    checking = false;
                                }
                            }
                            else if (check.Image == purpleIcon)
                            {
                                if (thisPB.Image == blueIcon)
                                {
                                    checking = false;
                                }
                                else if (thisPB.Image == purpleIcon)
                                {
                                    checking = false;
                                }
                            } 
                        }
                    }
                    if (checking == true)
                    {
                        thisPB.BringToFront();
                        thisPB.Left += move;
                    }
                }
                didWin();
            }
            else if (selectedBox == false)
            {
                MessageBox.Show("Please select an icon first", "QGame", MessageBoxButtons.OK);
            }
        }
    }
}
