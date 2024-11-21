using ChessMaze;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace WPFLevelDesignerView
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class LevelDesignerWindow : Window
    {
        private LevelDesigner _levelDesigner;
        private string _levelName;
        private int[] _levelSize;
        private PieceType _selectedPiece = PieceType.Empty;
        private SelectionMode _currentSelectionMode = SelectionMode.None;

        public LevelDesignerWindow(LevelDesigner levelDesigner, bool savedState)
        {
            InitializeComponent();
            _levelDesigner = levelDesigner;
            _levelName = levelDesigner.GetLevelName();
            _levelSize = levelDesigner.GetBoardSize();
            nameWindow();
            updateLabels();
            createChessBoard();
            SaveLoader(savedState);
        }

        private void nameWindow()
        {
            this.Title = $"Level Designer - {_levelName}";
        }

        private void updateLabels()
        {
            labelLevelName.Content = $"Level Name: {_levelName}";
            labelLevelSize.Content = $"Level Size: {_levelSize[0]}x{_levelSize[1]}";
        }

        private void createChessBoard()
        {
            const int squareSize = 50;
            pnlChessBoard.Children.Clear();

            // Create a Grid to represent the chessboard
            Grid grid = new Grid();

            // Define the number of rows and columns based on the level size
            for (int row = 0; row < _levelSize[1]; row++)
            {
                grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(squareSize) });
            }
            for (int col = 0; col < _levelSize[0]; col++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(squareSize) });
            }

            // Loop to create the tiles and place them in the grid
            for (int row = 0; row < _levelSize[1]; row++)
            {
                for (int col = 0; col < _levelSize[0]; col++)
                {
                    var tile = new Button
                    {
                        Width = squareSize,
                        Height = squareSize,
                        Background = (row + col) % 2 == 0 ? Brushes.White : Brushes.Black,
                        Tag = new Position(row, col)
                    };

                    tile.Click += Tile_Click;

                    // Place the button in the appropriate row and column
                    Grid.SetRow(tile, row);
                    Grid.SetColumn(tile, col);

                    grid.Children.Add(tile);
                }
            }

            // Add the grid to pnlChessBoard (make sure pnlChessBoard is a Grid or something capable of containing a Grid)
            pnlChessBoard.Children.Add(grid);
        }

        private void Tile_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            Position position = (Position)button.Tag;

            placePieceOnTile(position, _selectedPiece);
            updateTileImage(position, button);
        }

        private void changeTileColor(IPosition point, Button button)
        {
            if (_currentSelectionMode != SelectionMode.None)
            {
                if (_currentSelectionMode == SelectionMode.StartPoint)
                {
                    IPosition oldStart = _levelDesigner.GetStartPosition();
                    if (oldStart != null && !oldStart.Equals(point))
                    {
                        var oldStartButton = GetTileAtPosition(oldStart);
                        if (oldStartButton != null)
                        {
                            oldStartButton.Background = (oldStart.Row + oldStart.Column) % 2 == 0 ? Brushes.White : Brushes.Black;
                        }
                    }

                    _levelDesigner.SetStartPosition(point);
                    button.Background = Brushes.LightGreen;
                }
                else if (_currentSelectionMode == SelectionMode.FinishPoint)
                {
                    IPosition oldEnd = _levelDesigner.GetEndPosition();
                    if (oldEnd != null && !oldEnd.Equals(point))
                    {
                        var oldEndButton = GetTileAtPosition(oldEnd);
                        if (oldEndButton != null)
                        {
                            oldEndButton.Background = (oldEnd.Row + oldEnd.Column) % 2 == 0 ? Brushes.White : Brushes.Black;
                        }
                    }

                    _levelDesigner.SetEndPosition(point);
                    button.Background = Brushes.Red;
                }
                else if (_currentSelectionMode == SelectionMode.RemoveGoal)
                {
                    try
                    {
                        _levelDesigner.RemoveGoal(point);
                    }
                    catch (ArgumentException)
                    {
                        MessageBox.Show($"Error: No Goal at at this position","No Goal Found", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    
                    button.Background = (point.Row + point.Column) % 2 == 0 ? Brushes.White : Brushes.Black;
                }
                else if (_currentSelectionMode == SelectionMode.Goal)
                {
                    _levelDesigner.AddGoal(point);
                    button.Background = Brushes.Yellow;
                }

                _currentSelectionMode = SelectionMode.None;
            }
        }

        private Button GetTileAtPosition(IPosition position)
        {
            foreach (UIElement element in pnlChessBoard.Children)
            {
                if (element is Button button && button.Tag is Position buttonPosition && buttonPosition.Equals(position))
                {
                    return button;
                }
            }
            return null;
        }

        private void placePieceOnTile(Position position, PieceType piece)
        {
            if (piece == PieceType.Empty)
            {
                _levelDesigner.RemovePiece(position);
            }
            else
            {
                _levelDesigner.PlacePiece(piece, position);
            }
        }

        private void updateTileImage(Position point, Button button)
        {
            IPiece pieceAt = _levelDesigner.GetPieceAt(point);

            string pieceImagePath = pieceAt.Type switch
            {
                PieceType.Pawn => button.Background == Brushes.Black ? "pawn_w.png" : "pawn_b.png",
                PieceType.Rook => button.Background == Brushes.Black ? "rook_w.png" : "rook_b.png",
                PieceType.Bishop => button.Background == Brushes.Black ? "bishop_w.png" : "bishop_b.png",
                PieceType.Knight => button.Background == Brushes.Black ? "knight_w.png" : "knight_b.png",
                PieceType.King => button.Background == Brushes.Black ? "king_w.png" : "king_b.png",
                PieceType.Empty => null,
                _ => null
            };

            if (string.IsNullOrEmpty(pieceImagePath))
            {
                button.Content = null;
            }
            else
            {
                button.Content = new Image { Source = new BitmapImage(new Uri("Resources/Pieces/" + pieceImagePath, UriKind.Relative)) };
            }

            changeTileColor(point, button);
        }

        private void SaveLoader(bool isLoad)
        {
            foreach (UIElement element in pnlChessBoard.Children)
            {
                if (element is Button button)
                {
                    Position position = (Position)button.Tag;

                    if (isLoad)
                    {
                        IPiece pieceAt = _levelDesigner.GetPieceAt(position);

                        string pieceImagePath = pieceAt.Type switch
                        {
                            PieceType.Pawn => button.Background == Brushes.Black ? "pawn_w.png" : "pawn_b.png",
                            PieceType.Rook => button.Background == Brushes.Black ? "rook_w.png" : "rook_b.png",
                            PieceType.Bishop => button.Background == Brushes.Black ? "bishop_w.png" : "bishop_b.png",
                            PieceType.Knight => button.Background == Brushes.Black ? "knight_w.png" : "knight_b.png",
                            PieceType.King => button.Background == Brushes.Black ? "king_w.png" : "king_b.png",
                            PieceType.Empty => null,
                            _ => null
                        };

                        if (string.IsNullOrEmpty(pieceImagePath))
                        {
                            button.Content = null;
                        }
                        else
                        {
                            button.Content = new Image { Source = new BitmapImage(new Uri("Images/Pieces/" + pieceImagePath, UriKind.Relative)) };
                        }

                        if (_levelDesigner.GetStartPosition() == position)
                        {
                            button.Background = Brushes.LightGreen;
                        }
                        else if (_levelDesigner.GetEndPosition() == position)
                        {
                            button.Background = Brushes.Red;
                        }
                        else if (_levelDesigner.GetGoals().Contains(position))
                        {
                            button.Background = Brushes.Yellow;
                        }
                        else
                        {
                            button.Background = (position.Row + position.Column) % 2 == 0 ? Brushes.White : Brushes.Black;
                        }
                    }
                    else
                    {
                        button.Content = null;
                        button.Background = (position.Row + position.Column) % 2 == 0 ? Brushes.White : Brushes.Black;
                    }
                }
            }
        }

        private void buttonRename_Click(object sender, RoutedEventArgs e)
        {
            var newName = promptForName("Rename Level", "Enter a new name:", _levelName);

            if (!string.IsNullOrEmpty(newName))
            {
                _levelDesigner.SetLevelName(newName);
                _levelName = _levelDesigner.GetLevelName();
                nameWindow();
                updateLabels();
            }
        }

        public static string promptForName(string title, string promptText, string defaultValue = "")
        {
            var inputDialog = new InputDialog(title, promptText, defaultValue);
            if (inputDialog.ShowDialog() == true)
            {
                return inputDialog.ResponseText;
            }
            return null;
        }

        private void picBoxPawn_Click(object sender, RoutedEventArgs e)
        {
            labelSelectedPiece.Content = "Selected Piece: Pawn";
            _selectedPiece = PieceType.Pawn;
        }

        private void picBoxRook_Click(object sender, RoutedEventArgs e)
        {
            labelSelectedPiece.Content = "Selected Piece: Rook";
            _selectedPiece = PieceType.Rook;
        }

        private void picBoxBishop_Click(object sender, RoutedEventArgs e)
        {
            labelSelectedPiece.Content = "Selected Piece: Bishop";
            _selectedPiece = PieceType.Bishop;
        }

        private void picBoxKnight_Click(object sender, RoutedEventArgs e)
        {
            labelSelectedPiece.Content = "Selected Piece: Knight";
            _selectedPiece = PieceType.Knight;
        }

        private void picBoxKing_Click(object sender, RoutedEventArgs e)
        {
            labelSelectedPiece.Content = "Selected Piece: King";
            _selectedPiece = PieceType.King;
        }

        private void picBoxEmpty_Click(object sender, RoutedEventArgs e)
        {
            labelSelectedPiece.Content = "Selected Piece: Empty";
            _selectedPiece = PieceType.Empty;
        }

        private void btnStartPoint_Click(object sender, RoutedEventArgs e) 
        {
            labelTypeSelected.Content = "Start Selected";
            _currentSelectionMode = SelectionMode.StartPoint;
        }

        private void btnAddGoal_Click(object sender, RoutedEventArgs e)
        {
            labelTypeSelected.Content = "Add Goal Selected";
            _currentSelectionMode = SelectionMode.Goal;
        }

        private void btnSetFin_Click(object sender, RoutedEventArgs e)
        {
            labelTypeSelected.Content = "Set Finish Selected";
            _currentSelectionMode = SelectionMode.FinishPoint;
        }

        private void btnRemoveGoal_Click(object sender, RoutedEventArgs e)
        {
            labelTypeSelected.Content = "Remove Goal Selected";
            _currentSelectionMode = SelectionMode.RemoveGoal;
        }

        private void btnRemoveSelect_Click(object sender, RoutedEventArgs e)
        {
            labelTypeSelected.Content = "None Selected";
            _currentSelectionMode = SelectionMode.None;
        }

        private void btnRemoveAllGoals_Click(object sender, RoutedEventArgs e)
        {
            foreach (UIElement element in pnlChessBoard.Children)
            {
                if (element is Button button)
                {
                    // Check if the button's background color is yellow (goal color)
                    if (button.Background == Brushes.Yellow)
                    {
                        // Reset the button's background color based on the position
                        Position position = (Position)button.Tag;
                        button.Background = (position.Row + position.Column) % 2 == 0 ? Brushes.White : Brushes.Black;
                    }
                }
            }

            // Remove all goals from the level designer
            _levelDesigner.RemoveAllGoals();
        }
    }
}
