using System.Windows;

namespace WPFLevelDesignerView
{
    public partial class InputDialog : Window
    {
        public string ResponseText { get; set; }
        public string PromptText { get; set; }
        public string DefaultValue { get; set; }

        // Constructor for InputDialog
        public InputDialog(string title, string promptText, string defaultValue = "")
        {
            InitializeComponent();
            Title = title;  // Set the title of the window
            PromptText = promptText;  // Set the prompt text
            DefaultValue = defaultValue;  // Set the default value for the TextBox

            // Bind the properties to the UI elements
            DataContext = this;
        }

        // OK Button click handler
        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            ResponseText = InputTextBox.Text;  // Get the text from the TextBox
            DialogResult = true;  // Close the dialog with a result of "OK"
        }

        // Cancel Button click handler
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;  // Close the dialog without saving the input
        }
    }
}
