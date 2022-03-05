
namespace MTranQGame
{
    partial class DesignForm
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.toolBox = new System.Windows.Forms.GroupBox();
            this.btnPurpleIcon = new System.Windows.Forms.Button();
            this.btnBlueIcon = new System.Windows.Forms.Button();
            this.btnBlueDoor = new System.Windows.Forms.Button();
            this.btnPurpleDoor = new System.Windows.Forms.Button();
            this.btnNull = new System.Windows.Forms.Button();
            this.btnWall = new System.Windows.Forms.Button();
            this.txtRow = new System.Windows.Forms.TextBox();
            this.txtColumn = new System.Windows.Forms.TextBox();
            this.lblRow = new System.Windows.Forms.Label();
            this.lblColumn = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dialogSave = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolBox.SuspendLayout();
            this.menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Pink;
            this.btnGenerate.Location = new System.Drawing.Point(518, 3);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(103, 53);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // toolBox
            // 
            this.toolBox.Controls.Add(this.btnPurpleIcon);
            this.toolBox.Controls.Add(this.btnBlueIcon);
            this.toolBox.Controls.Add(this.btnBlueDoor);
            this.toolBox.Controls.Add(this.btnPurpleDoor);
            this.toolBox.Controls.Add(this.btnNull);
            this.toolBox.Controls.Add(this.btnWall);
            this.toolBox.Location = new System.Drawing.Point(0, 104);
            this.toolBox.Name = "toolBox";
            this.toolBox.Size = new System.Drawing.Size(263, 663);
            this.toolBox.TabIndex = 1;
            this.toolBox.TabStop = false;
            this.toolBox.Text = "Tool Box";
            // 
            // btnPurpleIcon
            // 
            this.btnPurpleIcon.Image = global::MTranQGame.Properties.Resources.purpleicon;
            this.btnPurpleIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurpleIcon.Location = new System.Drawing.Point(6, 552);
            this.btnPurpleIcon.Name = "btnPurpleIcon";
            this.btnPurpleIcon.Size = new System.Drawing.Size(201, 97);
            this.btnPurpleIcon.TabIndex = 9;
            this.btnPurpleIcon.Text = "Purple Icon";
            this.btnPurpleIcon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPurpleIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPurpleIcon.UseVisualStyleBackColor = true;
            this.btnPurpleIcon.Click += new System.EventHandler(this.btnPurpleIcon_Click);
            // 
            // btnBlueIcon
            // 
            this.btnBlueIcon.Image = global::MTranQGame.Properties.Resources.blueicon;
            this.btnBlueIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBlueIcon.Location = new System.Drawing.Point(6, 449);
            this.btnBlueIcon.Name = "btnBlueIcon";
            this.btnBlueIcon.Size = new System.Drawing.Size(201, 97);
            this.btnBlueIcon.TabIndex = 8;
            this.btnBlueIcon.Text = "Blue Icon";
            this.btnBlueIcon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBlueIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBlueIcon.UseVisualStyleBackColor = true;
            this.btnBlueIcon.Click += new System.EventHandler(this.btnBlueIcon_Click);
            // 
            // btnBlueDoor
            // 
            this.btnBlueDoor.Image = global::MTranQGame.Properties.Resources.bluedoor;
            this.btnBlueDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBlueDoor.Location = new System.Drawing.Point(6, 243);
            this.btnBlueDoor.Name = "btnBlueDoor";
            this.btnBlueDoor.Size = new System.Drawing.Size(201, 97);
            this.btnBlueDoor.TabIndex = 6;
            this.btnBlueDoor.Text = "Blue Door";
            this.btnBlueDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBlueDoor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBlueDoor.UseVisualStyleBackColor = true;
            this.btnBlueDoor.Click += new System.EventHandler(this.btnBlueDoor_Click);
            // 
            // btnPurpleDoor
            // 
            this.btnPurpleDoor.Image = global::MTranQGame.Properties.Resources.purpledoor;
            this.btnPurpleDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurpleDoor.Location = new System.Drawing.Point(6, 346);
            this.btnPurpleDoor.Name = "btnPurpleDoor";
            this.btnPurpleDoor.Size = new System.Drawing.Size(201, 97);
            this.btnPurpleDoor.TabIndex = 7;
            this.btnPurpleDoor.Text = "Purple Door";
            this.btnPurpleDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPurpleDoor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPurpleDoor.UseVisualStyleBackColor = true;
            this.btnPurpleDoor.Click += new System.EventHandler(this.btnPurpleDoor_Click);
            // 
            // btnNull
            // 
            this.btnNull.Image = global::MTranQGame.Properties.Resources._null;
            this.btnNull.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNull.Location = new System.Drawing.Point(6, 140);
            this.btnNull.Name = "btnNull";
            this.btnNull.Size = new System.Drawing.Size(167, 97);
            this.btnNull.TabIndex = 5;
            this.btnNull.Text = "Null";
            this.btnNull.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNull.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNull.UseVisualStyleBackColor = true;
            this.btnNull.Click += new System.EventHandler(this.btnNull_Click);
            // 
            // btnWall
            // 
            this.btnWall.Image = global::MTranQGame.Properties.Resources.wall;
            this.btnWall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWall.Location = new System.Drawing.Point(6, 37);
            this.btnWall.Name = "btnWall";
            this.btnWall.Size = new System.Drawing.Size(167, 97);
            this.btnWall.TabIndex = 4;
            this.btnWall.Text = "Wall";
            this.btnWall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWall.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWall.UseVisualStyleBackColor = true;
            this.btnWall.Click += new System.EventHandler(this.btnWall_Click);
            // 
            // txtRow
            // 
            this.txtRow.Location = new System.Drawing.Point(61, 16);
            this.txtRow.Name = "txtRow";
            this.txtRow.Size = new System.Drawing.Size(123, 26);
            this.txtRow.TabIndex = 1;
            // 
            // txtColumn
            // 
            this.txtColumn.Location = new System.Drawing.Point(369, 16);
            this.txtColumn.Name = "txtColumn";
            this.txtColumn.Size = new System.Drawing.Size(123, 26);
            this.txtColumn.TabIndex = 2;
            // 
            // lblRow
            // 
            this.lblRow.AutoSize = true;
            this.lblRow.Location = new System.Drawing.Point(10, 19);
            this.lblRow.Name = "lblRow";
            this.lblRow.Size = new System.Drawing.Size(45, 20);
            this.lblRow.TabIndex = 2;
            this.lblRow.Text = "Row:";
            // 
            // lblColumn
            // 
            this.lblColumn.AutoSize = true;
            this.lblColumn.Location = new System.Drawing.Point(296, 19);
            this.lblColumn.Name = "lblColumn";
            this.lblColumn.Size = new System.Drawing.Size(67, 20);
            this.lblColumn.TabIndex = 1;
            this.lblColumn.Text = "Column:";
            // 
            // menu
            // 
            this.menu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1111, 33);
            this.menu.TabIndex = 2;
            this.menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(151, 34);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtColumn);
            this.panel1.Controls.Add(this.btnGenerate);
            this.panel1.Controls.Add(this.txtRow);
            this.panel1.Controls.Add(this.lblRow);
            this.panel1.Controls.Add(this.lblColumn);
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1111, 62);
            this.panel1.TabIndex = 0;
            // 
            // DesignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1111, 777);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolBox);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "DesignForm";
            this.Text = "Design Form";
            this.toolBox.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.GroupBox toolBox;
        private System.Windows.Forms.TextBox txtRow;
        private System.Windows.Forms.TextBox txtColumn;
        private System.Windows.Forms.Label lblRow;
        private System.Windows.Forms.Label lblColumn;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog dialogSave;
        private System.Windows.Forms.Button btnWall;
        private System.Windows.Forms.Button btnNull;
        private System.Windows.Forms.Button btnBlueDoor;
        private System.Windows.Forms.Button btnPurpleIcon;
        private System.Windows.Forms.Button btnBlueIcon;
        private System.Windows.Forms.Button btnPurpleDoor;
        private System.Windows.Forms.Panel panel1;
    }
}