namespace ImageProcessing
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonFullScreen = new System.Windows.Forms.Button();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.panelWindow = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.buttonSelectImg = new System.Windows.Forms.Button();
            this.openFileDialogImg = new System.Windows.Forms.OpenFileDialog();
            this.buttonFindCenters = new System.Windows.Forms.Button();
            this.pictureBoxImg = new System.Windows.Forms.PictureBox();
            this.buttonGraph = new System.Windows.Forms.Button();
            this.panelWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImg)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Marlett", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonExit.Location = new System.Drawing.Point(548, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(29, 25);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.TabStop = false;
            this.buttonExit.Text = "r";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonFullScreen
            // 
            this.buttonFullScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFullScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonFullScreen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonFullScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFullScreen.Font = new System.Drawing.Font("Marlett", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonFullScreen.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonFullScreen.Location = new System.Drawing.Point(511, 3);
            this.buttonFullScreen.Name = "buttonFullScreen";
            this.buttonFullScreen.Size = new System.Drawing.Size(29, 25);
            this.buttonFullScreen.TabIndex = 0;
            this.buttonFullScreen.TabStop = false;
            this.buttonFullScreen.Text = "1";
            this.buttonFullScreen.UseVisualStyleBackColor = false;
            this.buttonFullScreen.Click += new System.EventHandler(this.buttonFullScreen_Click);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMinimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Font = new System.Drawing.Font("Marlett", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonMinimize.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonMinimize.Location = new System.Drawing.Point(475, 3);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(29, 25);
            this.buttonMinimize.TabIndex = 0;
            this.buttonMinimize.TabStop = false;
            this.buttonMinimize.Text = "0";
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // panelWindow
            // 
            this.panelWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelWindow.Controls.Add(this.labelTitle);
            this.panelWindow.Controls.Add(this.pictureBoxIcon);
            this.panelWindow.Controls.Add(this.buttonExit);
            this.panelWindow.Controls.Add(this.buttonMinimize);
            this.panelWindow.Controls.Add(this.buttonFullScreen);
            this.panelWindow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWindow.Location = new System.Drawing.Point(0, 0);
            this.panelWindow.Name = "panelWindow";
            this.panelWindow.Size = new System.Drawing.Size(580, 35);
            this.panelWindow.TabIndex = 1;
            this.panelWindow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelWindow_MouseDown);
            this.panelWindow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelWindow_MouseMove);
            this.panelWindow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelWindow_MouseUp);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTitle.Location = new System.Drawing.Point(45, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(57, 13);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "ImagePro";
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Image = global::ImageProcessing.Properties.Resources.ImageProBar;
            this.pictureBoxIcon.Location = new System.Drawing.Point(12, 5);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIcon.TabIndex = 2;
            this.pictureBoxIcon.TabStop = false;
            // 
            // buttonSelectImg
            // 
            this.buttonSelectImg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSelectImg.AutoSize = true;
            this.buttonSelectImg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSelectImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSelectImg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSelectImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectImg.ForeColor = System.Drawing.Color.White;
            this.buttonSelectImg.Location = new System.Drawing.Point(248, 69);
            this.buttonSelectImg.Name = "buttonSelectImg";
            this.buttonSelectImg.Size = new System.Drawing.Size(84, 25);
            this.buttonSelectImg.TabIndex = 0;
            this.buttonSelectImg.Text = "Select Image";
            this.buttonSelectImg.UseVisualStyleBackColor = false;
            this.buttonSelectImg.Click += new System.EventHandler(this.buttonSelectImg_Click);
            // 
            // openFileDialogImg
            // 
            this.openFileDialogImg.FileName = "openFileDialog";
            // 
            // buttonFindCenters
            // 
            this.buttonFindCenters.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonFindCenters.AutoSize = true;
            this.buttonFindCenters.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonFindCenters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonFindCenters.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonFindCenters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFindCenters.ForeColor = System.Drawing.Color.White;
            this.buttonFindCenters.Location = new System.Drawing.Point(50, 621);
            this.buttonFindCenters.Name = "buttonFindCenters";
            this.buttonFindCenters.Size = new System.Drawing.Size(84, 25);
            this.buttonFindCenters.TabIndex = 0;
            this.buttonFindCenters.Text = "Find Centers";
            this.buttonFindCenters.UseVisualStyleBackColor = false;
            this.buttonFindCenters.Click += new System.EventHandler(this.buttonFindCenters_Click);
            // 
            // pictureBoxImg
            // 
            this.pictureBoxImg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxImg.BackColor = System.Drawing.Color.White;
            this.pictureBoxImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImg.Location = new System.Drawing.Point(50, 120);
            this.pictureBoxImg.Name = "pictureBoxImg";
            this.pictureBoxImg.Size = new System.Drawing.Size(480, 480);
            this.pictureBoxImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImg.TabIndex = 2;
            this.pictureBoxImg.TabStop = false;
            // 
            // buttonGraph
            // 
            this.buttonGraph.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonGraph.AutoSize = true;
            this.buttonGraph.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonGraph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonGraph.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGraph.ForeColor = System.Drawing.Color.White;
            this.buttonGraph.Location = new System.Drawing.Point(479, 621);
            this.buttonGraph.Name = "buttonGraph";
            this.buttonGraph.Size = new System.Drawing.Size(51, 25);
            this.buttonGraph.TabIndex = 0;
            this.buttonGraph.Text = "Graph";
            this.buttonGraph.UseVisualStyleBackColor = false;
            this.buttonGraph.Click += new System.EventHandler(this.buttonGraph_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(580, 670);
            this.Controls.Add(this.pictureBoxImg);
            this.Controls.Add(this.buttonGraph);
            this.Controls.Add(this.buttonFindCenters);
            this.Controls.Add(this.buttonSelectImg);
            this.Controls.Add(this.panelWindow);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(580, 670);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImagePro";
            this.panelWindow.ResumeLayout(false);
            this.panelWindow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonFullScreen;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Panel panelWindow;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonSelectImg;
        private System.Windows.Forms.PictureBox pictureBoxImg;
        private System.Windows.Forms.OpenFileDialog openFileDialogImg;
        private System.Windows.Forms.Button buttonFindCenters;
        private System.Windows.Forms.Button buttonGraph;
    }
}

