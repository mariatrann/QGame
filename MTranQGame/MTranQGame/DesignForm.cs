/*
 * Program Name: MTranQGame
 * 
 * Purpose: To create a functioning Q-Puzzle game
 * 
 * Revision History:
 *      created by Maria Tran on Oct 7, 2021
 *      coded by Maria Tran on Oct 7, 2021
 *      coded by Maria Tran on Oct 25, 2021
 *      coded by Maria Tran on Oct 26, 2021
 *      coded by Maria Tran on Nov 03, 2021
 *      coded by Maria Tran on Nov 17, 2021
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTranQGame
{
    /// <summary>
    /// Design Form
    /// </summary>
    public partial class DesignForm : Form
    {
        /// <summary>
        /// Global variables
        /// </summary>
        private const int LEFT = 186;
        private const int TOP = 74;
        private const int HGAP = 3;
        private const int VGAP = 3;
        private const int WIDTH = 75;
        private const int HEIGHT = 75;
        private const int NULL = 0;
        private const int WALL = 1;
        private const int BLUE_DOOR = 2;
        private const int PURPLE_DOOR = 3;
        private const int BLUE_ICON = 6;
        private const int PURPLE_ICON = 7;
        Image image;
        int column = 0;
        int row = 0;
        int countWalls = 0;
        int countDoors = 0;
        int countIcons = 0;
        int type = 0;
        StreamWriter writer;
        List<PictureBox> listPic = new List<PictureBox>();

        /// <summary>
        /// Default Constructor
        /// </summary>
        public DesignForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This will create the grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerate_Click(object sender, EventArgs e)
        {

            try
            {
                column = Int32.Parse(txtColumn.Text);
                row = Int32.Parse(txtRow.Text);
                int totalboxes = row * column;
                int x = LEFT;
                int y = TOP;
                Size size = new Size(WIDTH, HEIGHT);

                for (int i = 0; i < totalboxes; i++)
                {
                    int currentColumn = i % column;
                    int currentRow = i / column;
                    int currentX = x + currentColumn * WIDTH;
                    int currentY = y + currentRow * HEIGHT;

                    PictureBox pb = new PictureBox
                    {
                        Size = size,
                        Location = new Point(currentX, currentY),
                        BorderStyle = BorderStyle.FixedSingle,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Name = currentRow.ToString() + "\n" + currentColumn.ToString(),
                        Tag = NULL

                    };
                    pb.Click += pb_Click;
                    this.Controls.Add(pb);
                    listPic.Add(pb);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error, please enter valid numbers only(integers).","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// This will change the pictures on the grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pb_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;

            if(pic.Image == null)
            {
                pic.Image = image;

                if (image == btnWall.Image)
                {
                    type = WALL;
                    pic.Tag = type;
                    countWalls++;
                }
                else if (image == btnBlueDoor.Image)
                {
                    type = BLUE_DOOR;
                    pic.Tag = type;
                    countDoors++;
                }
                else if (image == btnPurpleDoor.Image)
                {
                    type = PURPLE_DOOR;
                    pic.Tag = type;
                    countDoors++;
                }
                else if (image == btnBlueIcon.Image)
                {
                    type = BLUE_ICON;
                    pic.Tag = type;
                    countIcons++;
                }
                else if (image == btnPurpleIcon.Image)
                {
                    type = PURPLE_ICON;
                    pic.Tag = type;
                    countIcons++;
                }
            }
            else if (pic.Image == btnWall.Image)
            {
                pic.Image = image;

                if (image == btnWall.Image)
                {
                    type = WALL;
                    pic.Tag = type;
                }
                else if (image == btnBlueDoor.Image)
                {
                    type = BLUE_DOOR;
                    pic.Tag = type;
                    countDoors++;
                    countWalls--;
                }
                else if (image == btnPurpleDoor.Image)
                {
                    type = PURPLE_DOOR;
                    pic.Tag = type;
                    countDoors++;
                    countWalls--;
                }
                else if (image == btnBlueIcon.Image)
                {
                    type = BLUE_ICON;
                    pic.Tag = type;
                    countIcons++;
                    countWalls--;
                }
                else if (image == btnPurpleIcon.Image)
                {
                    type = PURPLE_ICON;
                    pic.Tag = type;
                    countIcons++;
                    countWalls--;
                }
                else if(image == null)
                {
                    countWalls--;
                }
            }
            else if(pic.Image == btnBlueDoor.Image || pic.Image == btnPurpleDoor.Image)
            {
                pic.Image = image;

                if (image == btnWall.Image)
                {
                    type = WALL;
                    pic.Tag = type;
                    countWalls++;
                    countDoors--;
                }
                else if (image == btnBlueDoor.Image)
                {
                    type = BLUE_DOOR;
                    pic.Tag = type;
                }
                else if (image == btnPurpleDoor.Image)
                {
                    type = PURPLE_DOOR;
                    pic.Tag = type;
                }
                else if (image == btnBlueIcon.Image)
                {
                    type = BLUE_ICON;
                    pic.Tag = type;
                    countIcons++;
                    countDoors--;
                }
                else if (image == btnPurpleIcon.Image)
                {
                    type = PURPLE_ICON;
                    pic.Tag = type;
                    countIcons++;
                    countDoors--;
                }
                else if (image ==  null)
                {
                    countDoors--;
                }
            }
            else if(pic.Image == btnBlueIcon.Image || pic.Image == btnPurpleIcon.Image)
            {
                pic.Image = image;

                if (image == btnWall.Image)
                {
                    type = WALL;
                    pic.Tag = type;
                    countWalls++;
                    countIcons--;
                }
                else if (image == btnBlueDoor.Image)
                {
                    type = BLUE_DOOR;
                    pic.Tag = type;
                    countDoors++;
                    countIcons--;
                }
                else if (image == btnPurpleDoor.Image)
                {
                    type = PURPLE_DOOR;
                    pic.Tag = type;
                    countDoors++;
                    countIcons--;
                }
                else if (image == btnBlueIcon.Image)
                {
                    type = BLUE_ICON;
                    pic.Tag = type;
                }
                else if (image == btnPurpleIcon.Image)
                {
                    type = PURPLE_ICON;
                    pic.Tag = type;
                }
                else if(image == null)
                {
                    countIcons--;
                }
            }

            
        }

        /// <summary>
        /// This will save the columns, rows, and types of the pictureboxes
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="pictureBoxes"></param>
        private void save(string fileName, List<PictureBox> pictureBoxes)
        {
            try
            {
                using (writer = new StreamWriter(fileName))
                {
                    writer.WriteLine(txtRow.Text);
                    writer.WriteLine(txtColumn.Text);

                    foreach (PictureBox item in listPic)
                    {
                        writer.WriteLine(item.Name + "\n" + item.Tag);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in saving file, please try again: " + ex.Message);
            }
        }

        /// <summary>
        /// This will open the dialog box for saving and count the walls, doors, and icons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogSave.Filter = "Text file|*.txt|All files|*.*";
            DialogResult file = dialogSave.ShowDialog();

            switch (file)
            {
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    try
                    {
                        string fileName = dialogSave.FileName;
                        save(fileName, listPic);

                        MessageBox.Show("File saved succecssfully:\n" +
                            "Total walls: " + countWalls + "\n" +
                            "Total doors: " + countDoors + "\n" +
                            "Total icons: " + countIcons);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("There was an error in saving the file, please try again: " + ex.Message);
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

        /// <summary>
        /// This will change the picture to the wall
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWall_Click(object sender, EventArgs e)
        {
            image = btnWall.Image;
            type = WALL;
        }

        /// <summary>
        /// This will change the picture to null
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNull_Click(object sender, EventArgs e)
        {
            image = null;
            type = NULL;
        }

        /// <summary>
        /// This will change the picture to the blue door
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBlueDoor_Click(object sender, EventArgs e)
        {
            image = btnBlueDoor.Image;
            type = BLUE_DOOR;
        }

        /// <summary>
        /// This will change the picture to the purple door
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPurpleDoor_Click(object sender, EventArgs e)
        {
            image = btnPurpleDoor.Image;
            type = PURPLE_DOOR;
        }

        /// <summary>
        /// This will change the picture to the blue icon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBlueIcon_Click(object sender, EventArgs e)
        {
            image = btnBlueIcon.Image;
            type = BLUE_ICON;
        }

        /// <summary>
        /// This will change the picture to the purple icon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPurpleIcon_Click(object sender, EventArgs e)
        {
            image = btnPurpleIcon.Image;
            type = PURPLE_ICON;
        }
    }
}
