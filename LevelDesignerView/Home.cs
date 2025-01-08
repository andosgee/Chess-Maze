using ChessMaze;

namespace LevelDesignerView
{
    public partial class Home : Form
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

        private void BtnOpenFromFile_Click(object sender, EventArgs e)
        {
            string defaultName = "Medium Level";
            int widthHeight = 5;

            var levelDesigner = CreateDefaultLevel(defaultName, widthHeight);

            var levelDesignerForm = new LevelDesignerForm(levelDesigner, true);
            levelDesignerForm.Show();
            this.Hide();
            levelDesignerForm.FormClosed += (s, args) => this.Show();

        }

        private void BtnLevelDesigner_Click(object sender, EventArgs e)
        {
            // Open the Level Designer Prompt
            using (var prompt = new LevelDesignerPrompt())
            {
                var result = prompt.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // Retrieve values and open Level Designer form
                    string levelName = prompt.LevelName;
                    int width = prompt.GridWidth;
                    int height = prompt.GridHeight;

                    // Create a new Instance of LevelDesigner
                    var levelDesigner = new LevelDesigner(width,height,levelName);


                    // Pass the values to the next form
                    var levelDesignerForm = new LevelDesignerForm(levelDesigner, false);
                    levelDesignerForm.Show();
                    this.Hide();
                    levelDesignerForm.FormClosed += (s, args) => this.Show();

                }
                else
                {
                    // User canceled; do nothing or show a message
                }
            }
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Play feature has not been implemented.", "Play", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
