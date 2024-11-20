using ChessMaze;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LevelDesignerView
{
    public partial class LevelDesignerPrompt : Form
    {
        public string LevelName { get; private set; }
        public int GridWidth { get; private set; }
        public int GridHeight { get; private set; }

        public LevelDesignerPrompt()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Validate inputs (optional)
            if (string.IsNullOrWhiteSpace(txtLevelName.Text))
            {
                MessageBox.Show("Level name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if ((int)numericUpDownWidthHeight.Value < 3 || (int)numericUpDownWidthHeight.Value > 9)
            {
                MessageBox.Show("Level needs to be bigger than 3 and smaller than 9.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Assign values
            LevelName = txtLevelName.Text;
            GridWidth = (int)numericUpDownWidthHeight.Value;
            GridHeight = (int)numericUpDownWidthHeight.Value;

            // Close dialog and signal success
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close dialog and signal cancellation
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
