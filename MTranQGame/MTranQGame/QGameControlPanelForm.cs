/*
 * Program Name: MTranQGame
 * 
 * Purpose: To create a functioning Q-Puzzle game
 * 
 * Revision History:
 *      created by Maria Tran on Oct 07, 2021
 *      coded by Maria Tran on Oct 07, 2021
 *      coded by Maria Tran on Oct 26, 2021
 *      coded by Maria Tran on Nov 06, 2021
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTranQGame
{
    /// <summary>
    /// Control Panel Form
    /// </summary>
    public partial class QGameControlPanelForm : Form
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public QGameControlPanelForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This will show the design form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDesign_Click(object sender, EventArgs e)
        {
            DesignForm design = new DesignForm();
            design.Show();
            //This will disable the Design button so ensure the Design Form will not
            //be opened multiple times
            btnDesign.Enabled = false;
            design.FormClosed += Design_FormClosed;
        }

        /// <summary>
        /// This will enable the Design button once the Design Form is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Design_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnDesign.Enabled = true;
        }

        /// <summary>
        /// This will enable the Play button once the Game Field is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameField_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnPlay.Enabled = true;
        }

        /// <summary>
        /// This will play the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlay_Click(object sender, EventArgs e)
        {
            GameField gameField = new GameField();
            gameField.Show();
            //This will disable the Play button so ensure the Game Field will not
            //be opened multiple times
            btnPlay.Enabled = false;
            gameField.FormClosed += GameField_FormClosed;
        }

        /// <summary>
        /// This will close the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
