namespace ImageProcessing
{
    partial class GraphForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphForm));
            this.panelWindow = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.pictureBoxGraph = new System.Windows.Forms.PictureBox();
            this.treeViewGraph = new System.Windows.Forms.TreeView();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonShortest = new System.Windows.Forms.Button();
            this.labelGraphInfo = new System.Windows.Forms.Label();
            this.labelShortestPath = new System.Windows.Forms.Label();
            this.panelGraph = new System.Windows.Forms.Panel();
            this.panelWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraph)).BeginInit();
            this.panelGraph.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWindow
            // 
            this.panelWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelWindow.Controls.Add(this.labelTitle);
            this.panelWindow.Controls.Add(this.pictureBoxIcon);
            this.panelWindow.Controls.Add(this.buttonExit);
            this.panelWindow.Controls.Add(this.buttonMinimize);
            this.panelWindow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWindow.Location = new System.Drawing.Point(0, 0);
            this.panelWindow.Name = "panelWindow";
            this.panelWindow.Size = new System.Drawing.Size(1200, 35);
            this.panelWindow.TabIndex = 3;
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
            this.labelTitle.Size = new System.Drawing.Size(99, 13);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "ImagePro - Graph";
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
            this.buttonExit.Location = new System.Drawing.Point(1168, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(29, 25);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.TabStop = false;
            this.buttonExit.Text = "r";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMinimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Font = new System.Drawing.Font("Marlett", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonMinimize.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonMinimize.Location = new System.Drawing.Point(1133, 3);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(29, 25);
            this.buttonMinimize.TabIndex = 0;
            this.buttonMinimize.TabStop = false;
            this.buttonMinimize.Text = "0";
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // pictureBoxGraph
            // 
            this.pictureBoxGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxGraph.BackColor = System.Drawing.Color.White;
            this.pictureBoxGraph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxGraph.Location = new System.Drawing.Point(27, 54);
            this.pictureBoxGraph.Name = "pictureBoxGraph";
            this.pictureBoxGraph.Size = new System.Drawing.Size(800, 800);
            this.pictureBoxGraph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGraph.TabIndex = 4;
            this.pictureBoxGraph.TabStop = false;
            this.pictureBoxGraph.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxGraph_MouseDoubleClick);
            // 
            // treeViewGraph
            // 
            this.treeViewGraph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.treeViewGraph.ForeColor = System.Drawing.SystemColors.Control;
            this.treeViewGraph.Location = new System.Drawing.Point(860, 94);
            this.treeViewGraph.Name = "treeViewGraph";
            this.treeViewGraph.Size = new System.Drawing.Size(302, 443);
            this.treeViewGraph.TabIndex = 5;
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonBack.AutoSize = true;
            this.buttonBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(1145, 843);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(43, 25);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonShortest
            // 
            this.buttonShortest.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonShortest.AutoSize = true;
            this.buttonShortest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonShortest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonShortest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonShortest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShortest.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShortest.ForeColor = System.Drawing.Color.White;
            this.buttonShortest.Location = new System.Drawing.Point(910, 577);
            this.buttonShortest.Name = "buttonShortest";
            this.buttonShortest.Size = new System.Drawing.Size(196, 25);
            this.buttonShortest.TabIndex = 6;
            this.buttonShortest.Text = "Shortest Path Containing 4 Nodes";
            this.buttonShortest.UseVisualStyleBackColor = false;
            this.buttonShortest.Click += new System.EventHandler(this.buttonShortest_Click);
            // 
            // labelGraphInfo
            // 
            this.labelGraphInfo.AutoSize = true;
            this.labelGraphInfo.Location = new System.Drawing.Point(979, 55);
            this.labelGraphInfo.Name = "labelGraphInfo";
            this.labelGraphInfo.Size = new System.Drawing.Size(63, 13);
            this.labelGraphInfo.TabIndex = 7;
            this.labelGraphInfo.Text = "Graph Info";
            // 
            // labelShortestPath
            // 
            this.labelShortestPath.AutoEllipsis = true;
            this.labelShortestPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelShortestPath.Location = new System.Drawing.Point(0, 0);
            this.labelShortestPath.Name = "labelShortestPath";
            this.labelShortestPath.Size = new System.Drawing.Size(302, 41);
            this.labelShortestPath.TabIndex = 8;
            this.labelShortestPath.Text = "Shortest path weigh:  ";
            this.labelShortestPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelShortestPath.Visible = false;
            // 
            // panelGraph
            // 
            this.panelGraph.Controls.Add(this.labelShortestPath);
            this.panelGraph.Location = new System.Drawing.Point(860, 620);
            this.panelGraph.Name = "panelGraph";
            this.panelGraph.Size = new System.Drawing.Size(302, 41);
            this.panelGraph.TabIndex = 9;
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 880);
            this.Controls.Add(this.panelGraph);
            this.Controls.Add(this.labelGraphInfo);
            this.Controls.Add(this.buttonShortest);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.treeViewGraph);
            this.Controls.Add(this.pictureBoxGraph);
            this.Controls.Add(this.panelWindow);
            this.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GraphForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Graph";
            this.panelWindow.ResumeLayout(false);
            this.panelWindow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraph)).EndInit();
            this.panelGraph.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelWindow;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.PictureBox pictureBoxGraph;
        private System.Windows.Forms.TreeView treeViewGraph;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonShortest;
        private System.Windows.Forms.Label labelGraphInfo;
        private System.Windows.Forms.Label labelShortestPath;
        private System.Windows.Forms.Panel panelGraph;
    }
}