# Chess Maze
A C# .NET application that focuses on the Level Designer Implementation for a Chess Maze.
___
## Table of Contents
- [About](#about)
- [Installation](#installation)
- [License](#license)
___
## About

[View my Website Write Up](https://andrewdevelops.com/index.php/2025/01/08/chess-maze-level-designer/)

This project was made in stages. 
The first was to implement to create a Model for the Level Designer aspect of a Chess Maze game. The program contains several features for how the model, level designer, should act.
#### Features
- Create Level	
- Set Level Size-
- Get Level Size
- Set Level Name
- Get Level Name
- Place Piece
- Remove Piece
- Get Piece At
- Piece Validation
- Check Board Bounds
- Set Start Point
- Set Finish Point
- Add Goal
- Remove Goal
- Remove All Goals
- Get Goals
- Get Start Point
- Get Finish Point

Once the model was created, there were several tests made to ensure that the model was acting correctly and that all results were correctly predicted. The testing of the model covered all [features](#features) implemented. The testing framework used was MSTest due to the framework being widely used and the ability for it to be cross platform enabled, along with ease of use with in Visual Studios own debugger.
![Model Tests](https://andrewdevelops.com/wp-content/uploads/2025/01/Tests-1.png)
![Testing of the model](https://andrewdevelops.com/wp-content/uploads/2025/01/Tests-Run.png)

The view was created second after the model had been created and passed its own tests. There were two views made, one with the WinForms framework and the other WPF. 
Winforms was used firstly as it is a well known and used framework for adding a GUI to C# applications. Winforms however is quite old and lacks some of the more modern features.
WPF on the other hand was a more modern approach of applying a GUI to a C# application and gives the window a more modern look. This is due to the native responsiveness of WPF and WPF design controls are made with XAML files which are more widely used across different platforms due its similarities of XML files.
### Winforms
![WinForms GUI](https://andrewdevelops.com/wp-content/uploads/2025/01/WinForms.png)
![WinForms GUI - Designer](https://andrewdevelops.com/wp-content/uploads/2025/01/Level-Designer.png)

### WPF
![WPF GUI](https://andrewdevelops.com/wp-content/uploads/2025/01/WPF.png)
![WPF GUI - Designer](https://andrewdevelops.com/wp-content/uploads/2025/01/LevelDesigner.png)

In the start menu, there is three options. Play, Load, and Create. Only create has been implemented at this point due to the scope of the project. The load button has been hard coded with a set level as a placeholder. Visual Studio 2022 Enterprise was used to create this application.
___
## Installation
1. Download or Clone the Repo.
2. Unzip the download (if applicable).
3. Open Visual Studio (not Visual Studio Code).
4. Open the Project.
5. Set the target project (Tests, or Views).
6. Run the Project.
___
## License
Distributed under the MIT License. See `LICENSE` for more information.
