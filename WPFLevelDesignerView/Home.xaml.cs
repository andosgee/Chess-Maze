using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ChessMaze;

namespace WPFLevelDesignerView
{
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
        }

        static LevelDesigner CreateDefaultLevel(string name, int widthHeight)
        {
            var levelDesigner = new LevelDesigner(widthHeight, widthHeight, name);

            // Add 2 goals (example positions 0,0 and 4,4)
            levelDesigner.AddGoal(new Position(0, 0));
            levelDesigner.AddGoal(new Position(4, 4));

            // Place some pieces (e.g., Pawn at (1,1), Rook at (2,2), and Knight at (3,3))
            levelDesigner.PlacePiece(PieceType.Pawn, new Position(1, 1));
            levelDesigner.PlacePiece(PieceType.Rook, new Position(2, 2));
            levelDesigner.PlacePiece(PieceType.Knight, new Position(3, 3));

            return levelDesigner;
        }

        private void BtnOpenFromFile_Click(object sender, RoutedEventArgs e)
        {
            string defaultName = "Medium Level";
            int widthHeight = 5;

            var levelDesigner = CreateDefaultLevel(defaultName, widthHeight);

            var levelDesignerForm = new LevelDesignerWindow(levelDesigner, true);
            levelDesignerForm.Show();
            this.Hide();
            levelDesignerForm.Closed += (s, args) => this.Show();
        }

        private void BtnLevelDesigner_Click(object sender, RoutedEventArgs e)
        {
            // Open the Level Designer Prompt
            var prompt = new LevelDesignerPrompt();
            if (prompt.ShowDialog() == true)
            {
                // Retrieve values and open Level Designer form
                string levelName = prompt.LevelName;
                int width = prompt.GridWidth;
                int height = prompt.GridHeight;

                // Create a new Instance of LevelDesigner
                var levelDesigner = new LevelDesigner(width, height, levelName);

                // Pass the values to the next form
                var levelDesignerForm = new LevelDesignerWindow(levelDesigner, false);
                levelDesignerForm.Show();
                this.Hide();
                levelDesignerForm.Closed += (s, args) => this.Show();
            }
        }

        private void BtnPlay_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Play feature has not been implemented.", "Play", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}