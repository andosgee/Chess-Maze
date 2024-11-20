namespace LevelDesignerView
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            btnOpenFromFile = new Button();
            btnLevelDesigner = new Button();
            btnPlay = new Button();
            picBoxFile = new PictureBox();
            picBoxDesigner = new PictureBox();
            picBoxPlay = new PictureBox();
            HomeTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)picBoxFile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxDesigner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxPlay).BeginInit();
            SuspendLayout();
            // 
            // btnOpenFromFile
            // 
            btnOpenFromFile.Location = new Point(225, 284);
            btnOpenFromFile.Name = "btnOpenFromFile";
            btnOpenFromFile.Size = new Size(113, 23);
            btnOpenFromFile.TabIndex = 0;
            btnOpenFromFile.Text = "Open From File";
            btnOpenFromFile.UseVisualStyleBackColor = true;
            btnOpenFromFile.Click += BtnOpenFromFile_Click;
            // 
            // btnLevelDesigner
            // 
            btnLevelDesigner.Location = new Point(359, 284);
            btnLevelDesigner.Name = "btnLevelDesigner";
            btnLevelDesigner.Size = new Size(105, 23);
            btnLevelDesigner.TabIndex = 1;
            btnLevelDesigner.Text = "Level Designer";
            btnLevelDesigner.UseVisualStyleBackColor = true;
            btnLevelDesigner.Click += BtnLevelDesigner_Click;
            // 
            // btnPlay
            // 
            btnPlay.Location = new Point(488, 284);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(75, 23);
            btnPlay.TabIndex = 2;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += BtnPlay_Click;
            // 
            // picBoxFile
            // 
            picBoxFile.BackgroundImage = (Image)resources.GetObject("picBoxFile.BackgroundImage");
            picBoxFile.BackgroundImageLayout = ImageLayout.Stretch;
            picBoxFile.Location = new Point(257, 211);
            picBoxFile.Name = "picBoxFile";
            picBoxFile.Size = new Size(50, 50);
            picBoxFile.TabIndex = 3;
            picBoxFile.TabStop = false;
            // 
            // picBoxDesigner
            // 
            picBoxDesigner.BackgroundImage = (Image)resources.GetObject("picBoxDesigner.BackgroundImage");
            picBoxDesigner.BackgroundImageLayout = ImageLayout.Stretch;
            picBoxDesigner.Location = new Point(384, 211);
            picBoxDesigner.Name = "picBoxDesigner";
            picBoxDesigner.Size = new Size(50, 50);
            picBoxDesigner.TabIndex = 4;
            picBoxDesigner.TabStop = false;
            // 
            // picBoxPlay
            // 
            picBoxPlay.BackgroundImage = (Image)resources.GetObject("picBoxPlay.BackgroundImage");
            picBoxPlay.BackgroundImageLayout = ImageLayout.Stretch;
            picBoxPlay.Location = new Point(488, 211);
            picBoxPlay.Name = "picBoxPlay";
            picBoxPlay.Size = new Size(75, 50);
            picBoxPlay.TabIndex = 5;
            picBoxPlay.TabStop = false;
            // 
            // HomeTitle
            // 
            HomeTitle.AutoSize = true;
            HomeTitle.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HomeTitle.Location = new Point(297, 77);
            HomeTitle.Name = "HomeTitle";
            HomeTitle.Size = new Size(215, 50);
            HomeTitle.TabIndex = 6;
            HomeTitle.Text = "Chess Maze";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(HomeTitle);
            Controls.Add(picBoxPlay);
            Controls.Add(picBoxDesigner);
            Controls.Add(picBoxFile);
            Controls.Add(btnPlay);
            Controls.Add(btnLevelDesigner);
            Controls.Add(btnOpenFromFile);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Home";
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)picBoxFile).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxDesigner).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxPlay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOpenFromFile;
        private Button btnLevelDesigner;
        private Button btnPlay;
        private PictureBox picBoxFile;
        private PictureBox picBoxDesigner;
        private PictureBox picBoxPlay;
        private Label HomeTitle;
    }
}
