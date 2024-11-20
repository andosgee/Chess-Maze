using ChessMaze;

namespace LevelDesignerView
{
    public partial class LevelDesignerForm : Form
    {
        private LevelDesigner _levelDesigner;
        private string _levelName;
        private int[] _levelSize;
        private PieceType _selectedPiece = PieceType.Empty;
        private SelectionMode _currentSelectionMode = SelectionMode.None;

        public LevelDesignerForm(LevelDesigner levelDesigner, bool savedState)
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

        /// <summary>
        /// Names the window based off the level name variable.
        /// </summary>
        private void nameWindow()
        {
            Text = $"Level Designer - {_levelName}";
        }

        /// <summary>
        /// Update the labels on the form.
        /// </summary>
        private void updateLabels()
        {
            labelLevelName.Text = $"Level Name: {_levelName}";
            labelLevelSize.Text = $"Level Size: {_levelSize[0]}x{_levelSize[1]}";
        }

        /// <summary>
        ///  Creates a chess board
        /// </summary>
        private void createChessBoard()
        {
            const int squareSize = 50;
            pnlChessBoard.Controls.Clear();

            pnlChessBoard.Size = new Size(_levelSize[0] * squareSize, _levelSize[1] * squareSize);

            for (int row = 0; row < _levelSize[1]; row++)
            {
                for (int col = 0; col < _levelSize[0]; col++)
                {
                    var tile = new PictureBox
                    {
                        Size = new Size(squareSize, squareSize),
                        Location = new Point(row * squareSize, col * squareSize),
                        BackColor = (row + col) % 2 == 0 ? Color.White : Color.Black,
                        BorderStyle = BorderStyle.FixedSingle,
                        Tag = new Position(row, col)
                    };

                    tile.Image = null;
                    tile.SizeMode = PictureBoxSizeMode.StretchImage;

                    tile.Click += Tile_Click;
                    pnlChessBoard.Controls.Add(tile);
                }
            }

        }

        /// <summary>
        /// Handles the Click on a tile
        /// </summary>
        /// <param name="sender">The tile (PictureBox) that was clicked</param>
        /// <param name="e">The Event</param>
        private void Tile_Click(object sender, EventArgs e)
        {
            var tile = sender as PictureBox;
            Position position = (Position)tile.Tag;

            // Place the piece on the board
            placePieceOnTile(position, _selectedPiece);


            // Update the tile image
            updateTileImage(position, tile);
        }

        private void changeTileColor(IPosition point, PictureBox tile)
        {
            if (_currentSelectionMode != SelectionMode.None)
            {
                // Only change the color if the tile is not the same as the existing start or end
                if (_currentSelectionMode == SelectionMode.StartPoint)
                {
                    // If there is already a start point, revert its color before changing
                    IPosition oldStart = _levelDesigner.GetStartPosition();
                    if (oldStart != null && !oldStart.Equals(point))
                    {
                        var oldStartTile = GetTileAtPosition(oldStart);
                        if (oldStartTile != null)
                        {
                            oldStartTile.BackColor = (oldStart.Row + oldStart.Column) % 2 == 0 ? Color.White : Color.Black;
                        }
                    }

                    _levelDesigner.SetStartPosition(point);
                    tile.BackColor = Color.LightGreen; // Set the color for the new start point
                }
                else if (_currentSelectionMode == SelectionMode.FinishPoint)
                {
                    // If there is already an end point, revert its color before changing
                    IPosition oldEnd = _levelDesigner.GetEndPosition();
                    if (oldEnd != null && !oldEnd.Equals(point))
                    {
                        var oldEndTile = GetTileAtPosition(oldEnd);
                        if (oldEndTile != null)
                        {
                            oldEndTile.BackColor = (oldEnd.Row + oldEnd.Column) % 2 == 0 ? Color.White : Color.Black;
                        }
                    }

                    _levelDesigner.SetEndPosition(point);
                    tile.BackColor = Color.Red; // Set the color for the new finish point
                }
                else if (_currentSelectionMode == SelectionMode.RemoveGoal)
                {
                    _levelDesigner.RemoveGoal(point);
                    tile.BackColor = (point.Row + point.Column) % 2 == 0 ? Color.White : Color.Black; // Reset the color after removal
                }
                else if (_currentSelectionMode == SelectionMode.Goal)
                {
                    _levelDesigner.AddGoal(point);
                    tile.BackColor = Color.Yellow; // Set the color for goal
                }

                // Reset the selection mode to none after handling the tile change
                _currentSelectionMode = SelectionMode.None;
            }
        }

        /// <summary>
        /// Gets the picturebox at the position
        /// </summary>
        /// <param name="position">The position of the tile to retrieve the corresponding PictureBox for.</param>
        /// <returns>Returns the PictureBox corresponding to the given position, or null if no match is found.</returns>
        private PictureBox GetTileAtPosition(IPosition position)
        {
            foreach (Control control in pnlChessBoard.Controls)
            {
                if (control is PictureBox tile && tile.Tag is Position tilePosition && tilePosition.Equals(position))
                {
                    return tile;
                }
            }
            return null;
        }

        /// <summary>
        /// Places a piece on the tile at the given position, or removes the piece if the specified piece type is Empty.
        /// </summary>
        /// <param name="position">The position on the chessboard where the piece should be placed or removed.</param>
        /// <param name="piece">Type of piece being placed</param>
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

        /// <summary>
        /// Updates the image on the tile based on the piece type at the specified position and updates the tile color.
        /// </summary>
        /// <param name="point">The position on the chessboard to check for a piece and update the image.</param>
        /// <param name="tile">The PictureBox representing the tile where the image will be updated.</param>
        private void updateTileImage(Position point, PictureBox tile)
        {
            IPiece pieceAt = _levelDesigner.GetPieceAt(point);

            // Image Path
            string pieceImagePath = pieceAt.Type switch
            {
                PieceType.Pawn => tile.BackColor == Color.Black ? "pawn_w.png" : "pawn_b.png",
                PieceType.Rook => tile.BackColor == Color.Black ? "rook_w.png" : "rook_b.png",
                PieceType.Bishop => tile.BackColor == Color.Black ? "bishop_w.png" : "bishop_b.png",
                PieceType.Knight => tile.BackColor == Color.Black ? "knight_w.png" : "knight_b.png",
                PieceType.King => tile.BackColor == Color.Black ? "king_w.png" : "king_b.png",
                PieceType.Empty => null,
                _ => null
            };

            if (string.IsNullOrEmpty(pieceImagePath))
            {
                tile.Image = null;
            }
            else
            {
                tile.Image = Image.FromFile("Images/Pieces/" + pieceImagePath);
                tile.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            changeTileColor(point, tile);

        }

        private void SaveLoader(bool isLoad)
        {
            // Iterate through each control on the chessboard panel
            foreach (Control control in pnlChessBoard.Controls)
            {
                if (control is PictureBox tile)
                {
                    Position position = (Position)tile.Tag;

                    // Debug: Check if position is correctly set
                    Console.WriteLine("Tile position: " + position);

                    // If loading, update the image and background based on the piece and state.
                    if (isLoad)
                    {
                        IPiece pieceAt = _levelDesigner.GetPieceAt(position);

                        // Image Path Logic for the chess pieces
                        string pieceImagePath = pieceAt.Type switch
                        {
                            PieceType.Pawn => tile.BackColor == Color.Black ? "pawn_w.png" : "pawn_b.png",
                            PieceType.Rook => tile.BackColor == Color.Black ? "rook_w.png" : "rook_b.png",
                            PieceType.Bishop => tile.BackColor == Color.Black ? "bishop_w.png" : "bishop_b.png",
                            PieceType.Knight => tile.BackColor == Color.Black ? "knight_w.png" : "knight_b.png",
                            PieceType.King => tile.BackColor == Color.Black ? "king_w.png" : "king_b.png",
                            PieceType.Empty => null,
                            _ => null
                        };

                        if (string.IsNullOrEmpty(pieceImagePath))
                        {
                            tile.Image = null;
                        }
                        else
                        {
                            tile.Image = Image.FromFile("Images/Pieces/" + pieceImagePath);
                            tile.SizeMode = PictureBoxSizeMode.StretchImage;
                        }

                        // Handle coloured square for Start, End, and Goals
                        if (_levelDesigner.GetStartPosition() == position)
                        {
                            tile.BackColor = Color.LightGreen; // Start position
                            Console.WriteLine("Start Position: " + position);
                        }
                        else if (_levelDesigner.GetEndPosition()== position)
                        {
                            tile.BackColor = Color.Red; // End position
                            Console.WriteLine("End Position: " + position);
                        }
                        else if (_levelDesigner.GetGoals().Contains(position))
                        {
                            tile.BackColor = Color.Yellow; // Goal position
                            Console.WriteLine("Goal Position: " + position);
                        }
                        else
                        {
                            tile.BackColor = (position.Row + position.Column) % 2 == 0 ? Color.White : Color.Black; // Regular board coloring
                        }
                    }
                    else
                    {
                        // Save logic: Set the image back to Empty (or save in the level data, depending on the implementation)
                        tile.Image = null;

                        // Reset the color to default when not loading
                        tile.BackColor = (position.Row + position.Column) % 2 == 0 ? Color.White : Color.Black; // Default board color
                    }
                }
            }
        }


        /// <summary>
        /// Handles the click event for the rename button. Prompts the user for a new level name, updates the level name if valid, and refreshes the UI.
        /// </summary>
        /// <param name="sender">The source of the event, typically the button that was clicked.</param>
        /// <param name="e">The event data associated with the click event.</param>
        private void buttonRename_Click(object sender, EventArgs e)
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

        /// <summary>
        /// Prompt for a setting a new level name.
        /// </summary>
        /// <param name="title">Name of the Window</param>
        /// <param name="promptText">Label of the input</param>
        /// <param name="defaultValue">Input value</param>
        /// <returns>String of new name</returns>
        public static string promptForName(string title, string promptText, string defaultValue = "")
        {
            using (var form = new Form())
            {
                var label = new Label { Text = promptText, Dock = DockStyle.Top, Padding = new Padding(10) };
                var textBox = new TextBox { Text = defaultValue, Dock = DockStyle.Top, Margin = new Padding(10) };
                var buttonOk = new Button { Text = "OK", DialogResult = DialogResult.OK, Dock = DockStyle.Right };
                var buttonCancel = new Button { Text = "Cancel", DialogResult = DialogResult.Cancel, Dock = DockStyle.Left };

                form.Text = title;
                form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
                form.AcceptButton = buttonOk;
                form.CancelButton = buttonCancel;

                return form.ShowDialog() == DialogResult.OK ? textBox.Text.Trim() : null;
            }
        }

        /// <summary>
        /// Handles the click event for selecting the Pawn piece. Updates the UI label and sets the selected piece type.
        /// </summary>
        /// <param name="sender">The source of the event, typically the PictureBox that was clicked.</param>
        /// <param name="e">The event data associated with the click event.</param>
        private void picBoxPawn_Click(object sender, EventArgs e)
        {
            labelSelectedPiece.Text = "Selected Piece: Pawn";
            _selectedPiece = PieceType.Pawn;
        }

        /// <summary>
        /// Handles the click event for selecting the Rook piece. Updates the UI label and sets the selected piece type.
        /// </summary>
        /// <param name="sender">The source of the event, typically the PictureBox that was clicked.</param>
        /// <param name="e">The event data associated with the click event.</param>
        private void picBoxRook_Click(object sender, EventArgs e)
        {
            labelSelectedPiece.Text = "Selected Piece: Rook";
            _selectedPiece = PieceType.Rook;
        }

        /// <summary>
        /// Handles the click event for selecting the Bishop piece. Updates the UI label and sets the selected piece type.
        /// </summary>
        /// <param name="sender">The source of the event, typically the PictureBox that was clicked.</param>
        /// <param name="e">The event data associated with the click event.</param>
        private void picBoxBishop_Click(object sender, EventArgs e)
        {
            labelSelectedPiece.Text = "Selected Piece: Bishop";
            _selectedPiece = PieceType.Bishop;
        }

        /// <summary>
        /// Handles the click event for selecting the Knight piece. Updates the UI label and sets the selected piece type.
        /// </summary>
        /// <param name="sender">The source of the event, typically the PictureBox that was clicked.</param>
        /// <param name="e">The event data associated with the click event.</param>
        private void picBoxKnight_Click(object sender, EventArgs e)
        {
            labelSelectedPiece.Text = "Selected Piece: Knight";
            _selectedPiece = PieceType.Knight;
        }

        /// <summary>
        /// Handles the click event for selecting the King piece. Updates the UI label and sets the selected piece type.
        /// </summary>
        /// <param name="sender">The source of the event, typically the PictureBox that was clicked.</param>
        /// <param name="e">The event data associated with the click event.</param>
        private void picBoxKing_Click(object sender, EventArgs e)
        {
            labelSelectedPiece.Text = "Selected Piece: King";
            _selectedPiece = PieceType.King;
        }

        /// <summary>
        /// Handles the click event for selecting the Empty piece. Updates the UI label and sets the selected piece type.
        /// </summary>
        /// <param name="sender">The source of the event, typically the PictureBox that was clicked.</param>
        /// <param name="e">The event data associated with the click event.</param>
        private void bicBoxEmpty_Click(object sender, EventArgs e)
        {
            labelSelectedPiece.Text = "Removing Pieces";
            _selectedPiece = PieceType.Empty;
        }

        /// <summary>
        /// Handles the click event for selecting the Start Point. Updates the UI label and sets the selection mode to Start Point.
        /// </summary>
        /// <param name="sender">The source of the event, typically the Button that was clicked.</param>
        /// <param name="e">The event data associated with the click event.</param>
        private void btnStartPoint_Click(object sender, EventArgs e)
        {
            labelTypeSelected.Text = "Start Selected";
            _currentSelectionMode = SelectionMode.StartPoint;
        }

        /// <summary>
        /// Handles the click event for selecting the Add Goal Point. Updates the UI label and sets the selection mode to Goal Point.
        /// </summary>
        /// <param name="sender">The source of the event, typically the Button that was clicked.</param>
        /// <param name="e">The event data associated with the click event.</param>
        private void btnAddGoal_Click(object sender, EventArgs e)
        {
            labelTypeSelected.Text = "Goal Selected";
            _currentSelectionMode = SelectionMode.Goal;
        }

        /// <summary>
        /// Handles the click event for selecting the Set Finish Point. Updates the UI label and sets the selection mode to Finish Point.
        /// </summary>
        /// <param name="sender">The source of the event, typically the Button that was clicked.</param>
        /// <param name="e">The event data associated with the click event.</param>
        private void btnSetFin_Click(object sender, EventArgs e)
        {
            labelTypeSelected.Text = "Set Finish Selected";
            _currentSelectionMode = SelectionMode.FinishPoint;
        }

        /// <summary>
        /// Handles the click event for selecting the Remove Selection. Updates the UI label and sets the selection mode to None.
        /// </summary>
        /// <param name="sender">The source of the event, typically the Button that was clicked.</param>
        /// <param name="e">The event data associated with the click event.</param>
        private void btnRemoveSelect_Click(object sender, EventArgs e)
        {
            labelTypeSelected.Text = "None Selected";
            _currentSelectionMode = SelectionMode.None;
        }

        /// <summary>
        /// Handles the click event for selecting the Remove Goal Point. Updates the UI label and sets the selection mode to Remove Goal Point.
        /// </summary>
        /// <param name="sender">The source of the event, typically the Button that was clicked.</param>
        /// <param name="e">The event data associated with the click event.</param>
        private void btnRemoveGoal_Click(object sender, EventArgs e)
        {
            _currentSelectionMode = SelectionMode.RemoveGoal;
        }

        /// <summary>
        /// Removes all the goals. Handles the click event.
        /// </summary>
        /// <param name="sender">The source of the event, typically the Button that was clicked.</param>
        /// <param name="e">The event data associated with the click event.</param>
        private void btnRemoveAllGoals_Click(object sender, EventArgs e)
        {
            foreach (Control control in pnlChessBoard.Controls)
            {
                // Check if the control is a PictureBox and its BackColor is yellow (goal color)
                if (control is PictureBox tile && tile.BackColor == Color.Yellow)
                {
                    // Reset the tile's BackColor to the default color (e.g., white or any other default)
                    tile.BackColor = (tile.Tag is Position position && (position.Row + position.Column) % 2 == 0)
                        ? Color.White
                        : Color.Black;
                }
            }
            _levelDesigner.RemoveAllGoals();

        }

        /// <summary>
        /// Handles the click event for the Save button. Displays a confirmation message when the save is successful.
        /// </summary>
        /// <param name="sender">The source of the event, typically the PictureBox (picBoxSave) that was clicked.</param>
        /// <param name="e">The event data associated with the click event.</param>
        private void picBoxSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
