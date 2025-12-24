# -Avoider (2D Windows Forms Game)

[![Built With C#](https://img.shields.io/badge/Built%20With-C%23-darkgreen.svg)](https://docs.microsoft.com/en-us/dotnet/csharp/)  [![Windows Forms](https://img.shields.io/badge/Framework-Windows%20Forms-lightgrey.svg)](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/)  [![GitHub Stars](https://img.shields.io/github/stars/Farnaztr/Avoider?style=social)](https://github.com/Farnaztr/Avoider/stargazers) [![Issues](https://img.shields.io/github/issues/Farnaztr/Avoider.svg)](https://github.com/Farnaztr/Avoider/issues)
 
---


## Overview
**Avoider** is a 2D game built with **C# and Windows Forms**.  
The goal is simple yet challenging: reach your home before time runs out while avoiding moving obstacles and managing your score.

- Start with **25 points**.
- **30 seconds** countdown timer.
- Colliding with obstacles **reduces 5 points**.
- If your score reaches zero before reaching home → **Game Over**.
- Reach home with remaining points before time ends → **Victory**.

## Features
- **Windows Forms GUI:** Uses PictureBoxes for player, obstacles, and home.
- **Collision Detection:** Hitting obstacles reduces the score.
- **Timer-based Gameplay:** Countdown timer and obstacle movement handled by Timers.
- **Dynamic Movement:** Player and obstacles move independently for a challenging experience.
- **Score System:** Tracks player points and displays win/lose messages.
- **Transparent Sprites:** Game elements are rendered with transparent backgrounds over the background image.

## Gameplay Mechanics
1. Click **Roll Dice** to start the game.
2. Move the player with **Arrow Keys or On-Screen Buttons**.
3. Obstacles automatically move across the screen.
4. Colliding with an obstacle: lose points and get pushed back.
5. Reach home before time ends → **Win**.
6. Time ends or score drops to zero → **Game Over**.

## Running the Game
After building the project in Visual Studio, the executable can be found in your local build directory. For example:
```
D:\Programming\c#\11th programs\ScoreGame\ScoreGame\bin\Debug\ScoreGame.exe
```
Double-click `ScoreGame.exe` to play the game.

## Controls
- **Arrow Keys / Buttons:** Move the player.
- **Roll Dice Button:** Start the game.
- **Timer:** 25 seconds countdown.
- **Score Label:** Displays current points.

## Technologies
- **C#**
- **Windows Forms**
- **Timers**
- **PictureBox GUI Components**
## Photos
<img width="500" height="500" alt="image" src="https://github.com/user-attachments/assets/a348f936-b291-47db-b95b-d945efbd7c93" />
<img width="500" height="500" alt="image" src="https://github.com/user-attachments/assets/0a880652-c520-4d4a-8422-6f0cdfdb1113" />
<img width="500" height="500" alt="image" src="https://github.com/user-attachments/assets/5b7e25fa-bc15-487f-9cb3-bc429a0827e7" />
<img width="500" height="500" alt="image" src="https://github.com/user-attachments/assets/14ea2346-63f4-41ba-b4a6-455a688215c4" />


## Author
**Farnaz Tarabi** – Computer student.
[GitHub Profile](https://github.com/Farnaztr)

