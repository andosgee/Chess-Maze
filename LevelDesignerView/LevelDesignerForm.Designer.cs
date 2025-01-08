namespace LevelDesignerView
{
    partial class LevelDesignerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LevelDesignerForm));
            labelLevelName = new Label();
            buttonRename = new Button();
            labelLevelSize = new Label();
            pnlChessBoard = new Panel();
            labelPieces = new Label();
            picBoxPawn = new PictureBox();
            picBoxRook = new PictureBox();
            picBoxBishop = new PictureBox();
            picBoxKnight = new PictureBox();
            picBoxKing = new PictureBox();
            bicBoxEmpty = new PictureBox();
            labelPawn = new Label();
            labelRook = new Label();
            labelBishop = new Label();
            labelKnight = new Label();
            labelKing = new Label();
            labelRemove = new Label();
            labelSelectedPiece = new Label();
            btnStartPoint = new Button();
            btnAddGoal = new Button();
            btnSetFin = new Button();
            btnRemoveGoal = new Button();
            btnRemoveSelect = new Button();
            btnRemoveAllGoals = new Button();
            labelTypeSelected = new Label();
            label2 = new Label();
            picBoxSave = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picBoxPawn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxRook).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxBishop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxKnight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxKing).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bicBoxEmpty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxSave).BeginInit();
            SuspendLayout();
            // 
            // labelLevelName
            // 
            labelLevelName.AutoSize = true;
            labelLevelName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLevelName.Location = new Point(12, 9);
            labelLevelName.Name = "labelLevelName";
            labelLevelName.Size = new Size(112, 21);
            labelLevelName.TabIndex = 0;
            labelLevelName.Text = "Level Designer";
            // 
            // buttonRename
            // 
            buttonRename.Location = new Point(30, 33);
            buttonRename.Name = "buttonRename";
            buttonRename.Size = new Size(75, 23);
            buttonRename.TabIndex = 1;
            buttonRename.Text = "Rename Level";
            buttonRename.UseVisualStyleBackColor = true;
            buttonRename.Click += buttonRename_Click;
            // 
            // labelLevelSize
            // 
            labelLevelSize.AutoSize = true;
            labelLevelSize.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLevelSize.Location = new Point(30, 59);
            labelLevelSize.Name = "labelLevelSize";
            labelLevelSize.Size = new Size(78, 21);
            labelLevelSize.TabIndex = 2;
            labelLevelSize.Text = "Level Size";
            // 
            // pnlChessBoard
            // 
            pnlChessBoard.BorderStyle = BorderStyle.FixedSingle;
            pnlChessBoard.Location = new Point(377, 62);
            pnlChessBoard.Name = "pnlChessBoard";
            pnlChessBoard.Size = new Size(316, 288);
            pnlChessBoard.TabIndex = 3;
            // 
            // labelPieces
            // 
            labelPieces.AutoSize = true;
            labelPieces.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPieces.Location = new Point(54, 114);
            labelPieces.Name = "labelPieces";
            labelPieces.Size = new Size(80, 32);
            labelPieces.TabIndex = 6;
            labelPieces.Text = "Pieces";
            // 
            // picBoxPawn
            // 
            picBoxPawn.BackColor = SystemColors.ControlLightLight;
            picBoxPawn.BackgroundImage = (Image)resources.GetObject("picBoxPawn.BackgroundImage");
            picBoxPawn.BackgroundImageLayout = ImageLayout.Stretch;
            picBoxPawn.Location = new Point(21, 149);
            picBoxPawn.Name = "picBoxPawn";
            picBoxPawn.Size = new Size(45, 45);
            picBoxPawn.TabIndex = 7;
            picBoxPawn.TabStop = false;
            picBoxPawn.Click += picBoxPawn_Click;
            // 
            // picBoxRook
            // 
            picBoxRook.BackColor = SystemColors.ControlLightLight;
            picBoxRook.BackgroundImage = (Image)resources.GetObject("picBoxRook.BackgroundImage");
            picBoxRook.BackgroundImageLayout = ImageLayout.Stretch;
            picBoxRook.Location = new Point(72, 149);
            picBoxRook.Name = "picBoxRook";
            picBoxRook.Size = new Size(45, 45);
            picBoxRook.TabIndex = 7;
            picBoxRook.TabStop = false;
            picBoxRook.Click += picBoxRook_Click;
            // 
            // picBoxBishop
            // 
            picBoxBishop.BackColor = SystemColors.ControlLightLight;
            picBoxBishop.BackgroundImage = (Image)resources.GetObject("picBoxBishop.BackgroundImage");
            picBoxBishop.BackgroundImageLayout = ImageLayout.Stretch;
            picBoxBishop.Location = new Point(123, 149);
            picBoxBishop.Name = "picBoxBishop";
            picBoxBishop.Size = new Size(45, 45);
            picBoxBishop.TabIndex = 7;
            picBoxBishop.TabStop = false;
            picBoxBishop.Click += picBoxBishop_Click;
            // 
            // picBoxKnight
            // 
            picBoxKnight.BackColor = SystemColors.ControlLightLight;
            picBoxKnight.BackgroundImage = (Image)resources.GetObject("picBoxKnight.BackgroundImage");
            picBoxKnight.BackgroundImageLayout = ImageLayout.Stretch;
            picBoxKnight.Location = new Point(21, 224);
            picBoxKnight.Name = "picBoxKnight";
            picBoxKnight.Size = new Size(45, 45);
            picBoxKnight.TabIndex = 7;
            picBoxKnight.TabStop = false;
            picBoxKnight.Click += picBoxKnight_Click;
            // 
            // picBoxKing
            // 
            picBoxKing.BackColor = SystemColors.ControlLightLight;
            picBoxKing.BackgroundImage = (Image)resources.GetObject("picBoxKing.BackgroundImage");
            picBoxKing.BackgroundImageLayout = ImageLayout.Stretch;
            picBoxKing.Location = new Point(72, 224);
            picBoxKing.Name = "picBoxKing";
            picBoxKing.Size = new Size(45, 45);
            picBoxKing.TabIndex = 7;
            picBoxKing.TabStop = false;
            picBoxKing.Click += picBoxKing_Click;
            // 
            // bicBoxEmpty
            // 
            bicBoxEmpty.BackColor = SystemColors.ControlLightLight;
            bicBoxEmpty.BackgroundImage = (Image)resources.GetObject("bicBoxEmpty.BackgroundImage");
            bicBoxEmpty.BackgroundImageLayout = ImageLayout.Stretch;
            bicBoxEmpty.Location = new Point(123, 224);
            bicBoxEmpty.Name = "bicBoxEmpty";
            bicBoxEmpty.Size = new Size(45, 45);
            bicBoxEmpty.TabIndex = 7;
            bicBoxEmpty.TabStop = false;
            bicBoxEmpty.Click += bicBoxEmpty_Click;
            // 
            // labelPawn
            // 
            labelPawn.AutoSize = true;
            labelPawn.Location = new Point(26, 197);
            labelPawn.Name = "labelPawn";
            labelPawn.Size = new Size(36, 15);
            labelPawn.TabIndex = 8;
            labelPawn.Text = "Pawn";
            // 
            // labelRook
            // 
            labelRook.AutoSize = true;
            labelRook.Location = new Point(77, 197);
            labelRook.Name = "labelRook";
            labelRook.Size = new Size(34, 15);
            labelRook.TabIndex = 9;
            labelRook.Text = "Rook";
            // 
            // labelBishop
            // 
            labelBishop.AutoSize = true;
            labelBishop.Location = new Point(123, 197);
            labelBishop.Name = "labelBishop";
            labelBishop.Size = new Size(43, 15);
            labelBishop.TabIndex = 10;
            labelBishop.Text = "Bishop";
            // 
            // labelKnight
            // 
            labelKnight.AutoSize = true;
            labelKnight.Location = new Point(23, 272);
            labelKnight.Name = "labelKnight";
            labelKnight.Size = new Size(42, 15);
            labelKnight.TabIndex = 11;
            labelKnight.Text = "Knight";
            // 
            // labelKing
            // 
            labelKing.AutoSize = true;
            labelKing.Location = new Point(81, 272);
            labelKing.Name = "labelKing";
            labelKing.Size = new Size(31, 15);
            labelKing.TabIndex = 12;
            labelKing.Text = "King";
            // 
            // labelRemove
            // 
            labelRemove.AutoSize = true;
            labelRemove.Location = new Point(120, 272);
            labelRemove.Name = "labelRemove";
            labelRemove.Size = new Size(50, 15);
            labelRemove.TabIndex = 13;
            labelRemove.Text = "Remove";
            // 
            // labelSelectedPiece
            // 
            labelSelectedPiece.AutoSize = true;
            labelSelectedPiece.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSelectedPiece.Location = new Point(33, 298);
            labelSelectedPiece.Name = "labelSelectedPiece";
            labelSelectedPiece.Size = new Size(133, 21);
            labelSelectedPiece.TabIndex = 15;
            labelSelectedPiece.Text = "No Piece Selected";
            // 
            // btnStartPoint
            // 
            btnStartPoint.BackColor = Color.Green;
            btnStartPoint.ForeColor = SystemColors.ControlLightLight;
            btnStartPoint.Location = new Point(12, 364);
            btnStartPoint.Name = "btnStartPoint";
            btnStartPoint.Size = new Size(75, 23);
            btnStartPoint.TabIndex = 16;
            btnStartPoint.Text = "Set Start";
            btnStartPoint.UseVisualStyleBackColor = false;
            btnStartPoint.Click += btnStartPoint_Click;
            // 
            // btnAddGoal
            // 
            btnAddGoal.BackColor = Color.Yellow;
            btnAddGoal.Location = new Point(95, 364);
            btnAddGoal.Name = "btnAddGoal";
            btnAddGoal.Size = new Size(75, 23);
            btnAddGoal.TabIndex = 17;
            btnAddGoal.Text = "Add Goal";
            btnAddGoal.UseVisualStyleBackColor = false;
            btnAddGoal.Click += btnAddGoal_Click;
            // 
            // btnSetFin
            // 
            btnSetFin.BackColor = Color.Red;
            btnSetFin.Location = new Point(176, 364);
            btnSetFin.Name = "btnSetFin";
            btnSetFin.Size = new Size(75, 23);
            btnSetFin.TabIndex = 18;
            btnSetFin.Text = "Set Finish";
            btnSetFin.UseVisualStyleBackColor = false;
            btnSetFin.Click += btnSetFin_Click;
            // 
            // btnRemoveGoal
            // 
            btnRemoveGoal.Location = new Point(148, 393);
            btnRemoveGoal.Name = "btnRemoveGoal";
            btnRemoveGoal.Size = new Size(103, 23);
            btnRemoveGoal.TabIndex = 19;
            btnRemoveGoal.Text = "Remove Goal";
            btnRemoveGoal.UseVisualStyleBackColor = true;
            btnRemoveGoal.Click += btnRemoveGoal_Click;
            // 
            // btnRemoveSelect
            // 
            btnRemoveSelect.Location = new Point(12, 393);
            btnRemoveSelect.Name = "btnRemoveSelect";
            btnRemoveSelect.Size = new Size(123, 23);
            btnRemoveSelect.TabIndex = 20;
            btnRemoveSelect.Text = "Remove Selection";
            btnRemoveSelect.UseVisualStyleBackColor = true;
            btnRemoveSelect.Click += btnRemoveSelect_Click;
            // 
            // btnRemoveAllGoals
            // 
            btnRemoveAllGoals.Location = new Point(54, 422);
            btnRemoveAllGoals.Name = "btnRemoveAllGoals";
            btnRemoveAllGoals.Size = new Size(139, 23);
            btnRemoveAllGoals.TabIndex = 21;
            btnRemoveAllGoals.Text = "Remove All Goals";
            btnRemoveAllGoals.UseVisualStyleBackColor = true;
            btnRemoveAllGoals.Click += btnRemoveAllGoals_Click;
            // 
            // labelTypeSelected
            // 
            labelTypeSelected.AutoSize = true;
            labelTypeSelected.Location = new Point(72, 335);
            labelTypeSelected.Name = "labelTypeSelected";
            labelTypeSelected.Size = new Size(83, 15);
            labelTypeSelected.TabIndex = 22;
            labelTypeSelected.Text = "None Selected";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 83);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 24;
            label2.Text = "Save";
            // 
            // picBoxSave
            // 
            picBoxSave.BackColor = SystemColors.ControlLightLight;
            picBoxSave.BackgroundImage = (Image)resources.GetObject("picBoxSave.BackgroundImage");
            picBoxSave.BackgroundImageLayout = ImageLayout.Stretch;
            picBoxSave.Location = new Point(139, 35);
            picBoxSave.Name = "picBoxSave";
            picBoxSave.Size = new Size(45, 45);
            picBoxSave.TabIndex = 25;
            picBoxSave.TabStop = false;
            picBoxSave.Click += picBoxSave_Click;
            // 
            // LevelDesignerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(picBoxSave);
            Controls.Add(label2);
            Controls.Add(labelTypeSelected);
            Controls.Add(btnRemoveAllGoals);
            Controls.Add(btnRemoveSelect);
            Controls.Add(btnRemoveGoal);
            Controls.Add(btnSetFin);
            Controls.Add(btnAddGoal);
            Controls.Add(btnStartPoint);
            Controls.Add(labelSelectedPiece);
            Controls.Add(labelRemove);
            Controls.Add(labelKing);
            Controls.Add(labelKnight);
            Controls.Add(labelBishop);
            Controls.Add(labelRook);
            Controls.Add(labelPawn);
            Controls.Add(bicBoxEmpty);
            Controls.Add(picBoxBishop);
            Controls.Add(picBoxKing);
            Controls.Add(picBoxRook);
            Controls.Add(picBoxKnight);
            Controls.Add(picBoxPawn);
            Controls.Add(labelPieces);
            Controls.Add(pnlChessBoard);
            Controls.Add(labelLevelSize);
            Controls.Add(buttonRename);
            Controls.Add(labelLevelName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LevelDesignerForm";
            Text = "Level Designer";
            ((System.ComponentModel.ISupportInitialize)picBoxPawn).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxRook).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxBishop).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxKnight).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxKing).EndInit();
            ((System.ComponentModel.ISupportInitialize)bicBoxEmpty).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxSave).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLevelName;
        private Button buttonRename;
        private Label labelLevelSize;
        private Panel pnlChessBoard;
        private Label labelRemove;
        private Label labelPieces;
        private PictureBox picBoxPawn;
        private PictureBox picBoxRook;
        private PictureBox picBoxBishop;
        private PictureBox picBoxKnight;
        private PictureBox picBoxKing;
        private PictureBox bicBoxEmpty;
        private Label labelPawn;
        private Label labelRook;
        private Label labelBishop;
        private Label labelKnight;
        private Label labelKing;
        private Label labelSelectedPiece;
        private Button btnStartPoint;
        private Button btnAddGoal;
        private Button btnSetFin;
        private Button btnRemoveGoal;
        private Button btnRemoveSelect;
        private Button btnRemoveAllGoals;
        private Label labelTypeSelected;
        private Label label2;
        private PictureBox picBoxSave;
    }
}