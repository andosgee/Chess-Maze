using System.DirectoryServices.ActiveDirectory;

namespace LevelDesignerView
{
    partial class LevelDesignerPrompt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LevelDesignerPrompt));
            labelHeading = new Label();
            labelLevelName = new Label();
            labelWidthHeight = new Label();
            btnCancel = new Button();
            btnCreate = new Button();
            txtLevelName = new TextBox();
            numericUpDownWidthHeight = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWidthHeight).BeginInit();
            SuspendLayout();
            // 
            // labelHeading
            // 
            labelHeading.AutoSize = true;
            labelHeading.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHeading.Location = new Point(194, 52);
            labelHeading.Name = "labelHeading";
            labelHeading.Size = new Size(416, 37);
            labelHeading.TabIndex = 0;
            labelHeading.Text = "Enter the level name and grid size";
            // 
            // labelLevelName
            // 
            labelLevelName.AutoSize = true;
            labelLevelName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLevelName.Location = new Point(194, 103);
            labelLevelName.Name = "labelLevelName";
            labelLevelName.Size = new Size(127, 30);
            labelLevelName.TabIndex = 1;
            labelLevelName.Text = "Level Name:";
            // 
            // labelWidthHeight
            // 
            labelWidthHeight.AutoSize = true;
            labelWidthHeight.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelWidthHeight.Location = new Point(194, 149);
            labelWidthHeight.Name = "labelWidthHeight";
            labelWidthHeight.Size = new Size(158, 30);
            labelWidthHeight.TabIndex = 2;
            labelWidthHeight.Text = "Width x Height:";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.IndianRed;
            btnCancel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(366, 251);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(102, 40);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.MediumSpringGreen;
            btnCreate.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreate.Location = new Point(508, 251);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(102, 40);
            btnCreate.TabIndex = 4;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtLevelName
            // 
            txtLevelName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLevelName.Location = new Point(327, 100);
            txtLevelName.Name = "txtLevelName";
            txtLevelName.Size = new Size(189, 35);
            txtLevelName.TabIndex = 5;
            // 
            // numericUpDownWidthHeight
            // 
            numericUpDownWidthHeight.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDownWidthHeight.Location = new Point(358, 147);
            numericUpDownWidthHeight.Name = "numericUpDownWidthHeight";
            numericUpDownWidthHeight.Size = new Size(44, 35);
            numericUpDownWidthHeight.TabIndex = 6;
            // 
            // LevelDesignerPrompt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(numericUpDownWidthHeight);
            Controls.Add(txtLevelName);
            Controls.Add(btnCreate);
            Controls.Add(btnCancel);
            Controls.Add(labelWidthHeight);
            Controls.Add(labelLevelName);
            Controls.Add(labelHeading);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LevelDesignerPrompt";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Level Creator";
            ((System.ComponentModel.ISupportInitialize)numericUpDownWidthHeight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHeading;
        private Label labelLevelName;
        private Label labelWidthHeight;
        private Button btnCancel;
        private Button btnCreate;
        private TextBox txtLevelName;
        private NumericUpDown numericUpDownWidthHeight;
    }
}