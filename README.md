# Avoider – 2D Windows Forms Game

![Game Screenshot](screenshot.png) 

## Overview
**Avoider** is a 2D game built with **C# and Windows Forms**.  
The goal is simple yet challenging: reach your home before time runs out while avoiding moving obstacles and managing your score.

- Start with **30 points**.
- **120 seconds** countdown timer.
- Colliding with obstacles **reduces 5 points**.
- If your score reaches zero before reaching home → **Game Over**.
- Reach home with remaining points before time ends → **Victory**.

---

## Features
- **Windows Forms GUI:** Uses PictureBoxes for player, obstacles, and home.
- **Collision Detection:** Hitting obstacles reduces the score.
- **Timer-based Gameplay:** Countdown timer and obstacle movement handled by Timers.
- **Dynamic Movement:** Player and obstacles move independently for a challenging experience.
- **Score System:** Tracks player points and displays win/lose messages.
- **Transparent Sprites:** Game elements are rendered with transparent backgrounds over the background image.

---

## Gameplay Mechanics
1. Click **Roll Dice** to start the game.
2. Move the player with **Arrow Keys or On-Screen Buttons**.
3. Obstacles automatically move across the screen.
4. Colliding with an obstacle: lose points and get pushed back.
5. Reach home before time ends → **Win**.
6. Time ends or score drops to zero → **Game Over**.

---

## Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/Avoider.git
