
namespace MTranQGame
{
    partial class GameField
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dialogOpen = new System.Windows.Forms.OpenFileDialog();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.lblNumOfMoves = new System.Windows.Forms.Label();
            this.txtNumOfMoves = new System.Windows.Forms.TextBox();
            this.txtRemainingIcons = new System.Windows.Forms.TextBox();
            this.lblRemainingIcons = new System.Windows.Forms.Label();
            this.panelGame = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1289, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(153, 34);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(153, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.Pink;
            this.btnUp.Enabled = false;
            this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.Location = new System.Drawing.Point(1127, 510);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(65, 65);
            this.btnUp.TabIndex = 3;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.Color.Pink;
            this.btnDown.Enabled = false;
            this.btnDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.Location = new System.Drawing.Point(1127, 581);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(65, 65);
            this.btnDown.TabIndex = 4;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.Pink;
            this.btnRight.Enabled = false;
            this.btnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight.Location = new System.Drawing.Point(1198, 581);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(65, 65);
            this.btnRight.TabIndex = 6;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.Pink;
            this.btnLeft.Enabled = false;
            this.btnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.Location = new System.Drawing.Point(1056, 581);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(65, 65);
            this.btnLeft.TabIndex = 5;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // lblNumOfMoves
            // 
            this.lblNumOfMoves.AutoSize = true;
            this.lblNumOfMoves.Location = new System.Drawing.Point(1040, 51);
            this.lblNumOfMoves.Name = "lblNumOfMoves";
            this.lblNumOfMoves.Size = new System.Drawing.Size(136, 20);
            this.lblNumOfMoves.TabIndex = 5;
            this.lblNumOfMoves.Text = "Number Of Moves";
            // 
            // txtNumOfMoves
            // 
            this.txtNumOfMoves.Location = new System.Drawing.Point(1039, 74);
            this.txtNumOfMoves.Name = "txtNumOfMoves";
            this.txtNumOfMoves.ReadOnly = true;
            this.txtNumOfMoves.Size = new System.Drawing.Size(210, 26);
            this.txtNumOfMoves.TabIndex = 1;
            // 
            // txtRemainingIcons
            // 
            this.txtRemainingIcons.Location = new System.Drawing.Point(1039, 159);
            this.txtRemainingIcons.Name = "txtRemainingIcons";
            this.txtRemainingIcons.ReadOnly = true;
            this.txtRemainingIcons.Size = new System.Drawing.Size(210, 26);
            this.txtRemainingIcons.TabIndex = 2;
            // 
            // lblRemainingIcons
            // 
            this.lblRemainingIcons.AutoSize = true;
            this.lblRemainingIcons.Location = new System.Drawing.Point(1040, 136);
            this.lblRemainingIcons.Name = "lblRemainingIcons";
            this.lblRemainingIcons.Size = new System.Drawing.Size(209, 20);
            this.lblRemainingIcons.TabIndex = 7;
            this.lblRemainingIcons.Text = "Number Of Remaining Icons";
            // 
            // panelGame
            // 
            this.panelGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGame.Location = new System.Drawing.Point(12, 50);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(997, 809);
            this.panelGame.TabIndex = 8;
            // 
            // GameField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1289, 871);
            this.Controls.Add(this.panelGame);
            this.Controls.Add(this.txtRemainingIcons);
            this.Controls.Add(this.lblRemainingIcons);
            this.Controls.Add(this.txtNumOfMoves);
            this.Controls.Add(this.lblNumOfMoves);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GameField";
            this.Text = "Game Field";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog dialogOpen;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Label lblNumOfMoves;
        private System.Windows.Forms.TextBox txtNumOfMoves;
        private System.Windows.Forms.TextBox txtRemainingIcons;
        private System.Windows.Forms.Label lblRemainingIcons;
        private System.Windows.Forms.Panel panelGame;
    }
}