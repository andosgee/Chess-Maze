using System;
using System.Windows;
using System.Windows.Controls;

namespace WPFLevelDesignerView
{
    public partial class LevelDesignerPrompt : Window
    {
        public string LevelName { get; private set; }
        public int GridWidth { get; private set; }
        public int GridHeight { get; private set; }

        public LevelDesignerPrompt()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtLevelName.Text))
            {
                MessageBox.Show("Level name is required.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (numericUpDownWidthHeight.SelectedItem == null ||
                int.TryParse(((ComboBoxItem)numericUpDownWidthHeight.SelectedItem).Content.ToString(), out int size) == false ||
                size < 3 || size > 9)
            {
                MessageBox.Show("Grid size must be between 3 and 9.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Assign values
            LevelName = txtLevelName.Text;
            GridWidth = GridHeight = size;

            // Close dialog and signal success
            DialogResult = true;
            Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            // Close dialog and signal cancellation
            DialogResult = false;
            Close();
        }
    }
}
