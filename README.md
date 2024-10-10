# UnityAnimalFeeding

This repository contains a Unity project for an interactive game where players can move left and right on the screen, interact with animals, and launch projectiles to feed them.

## Overview

The project allows players to control a character that can move horizontally while interacting with animals and food. Players can launch projectiles to feed the animals. Key components include:

- **Player Movement**: Implemented using user input to control side-to-side movement while keeping the player within bounds.
- **Animal Interaction**: Players can interact with animals by launching food at them.
- **Projectile Mechanics**: Players can launch projectiles that move across the screen.

## Project Structure

The project is organized into several key folders and scripts:

- **Assets**: Contains all imported assets, including player, animal, and food models.
- **Scripts**: Includes C# scripts for controlling player movement and projectile behavior.
  - `ControlPlayer.cs`: Manages player movement and bounds checking.
  - `MoveForward.cs`: Controls the forward movement of projectiles.
  - `Destroy.cs`: Handles the destruction of objects that leave the play area.
  - `SpawnManager.cs`: Manages the spawning of animals.

## Implementation Details

### Player Positioning

1. **Scene Setup**:
   - Created a new Unity project named "UnityAnimalFeeding" and imported the necessary starter files.
   - Added a player character, three animals, and one food object to the scene.

2. **User Input**:
   - Created a `ControlPlayer.cs` script to track user input for horizontal movement.
   - Used `Input.GetAxis("Horizontal")` to get user input and move the player left or right based on key presses.

3. **Movement Logic**:
   - Implemented movement logic using an if-statement to keep the player within defined bounds on both sides of the screen.


### Food Flight

1. **Projectile Setup**:
   - Created a `MoveForward` script to make the projectile fly forward when launched.
   - Made the projectile into a prefab for reuse throughout the game.

2. **Launching Projectiles**:
   - Implemented functionality to launch projectiles using the spacebar by instantiating the projectile prefab at the player's location.

3. **Prefab Management**:
   - Converted animals into prefabs that can be instantiated during gameplay.

4. **Object Destruction**:
   - Created a `Destroy.cs` script to destroy projectiles and animals that leave the play area.

### Random Animal Spawn

1. **Spawn Manager**:
   - Created an empty GameObject called "SpawnManager" to manage animal spawning.
   - Used arrays to store animal prefabs and spawn them randomly when the S key is pressed.

2. **Randomization**:
   - Randomized both animal selection and spawn locations using `Random.Range`.

3. **Camera Perspective**:
   - Adjusted camera settings from perspective to orthographic for a better top-down view of gameplay.

## MiniGame: Catching Falling Balls

1. **Challenge Overview**:
   - Programmed a mini-game where balls fall from the sky, and players must send their dog out to catch them before they hit the ground.

2. **Ball Generation**:
   - A random ball (of three types) is generated at a random x position above the screen.
   - When the user presses spacebar, a dog is spawned that runs to catch the ball.

3. **Collision Detection**:
   - If the dog collides with the ball, the ball is destroyed.
   - If the ball hits the ground, a "Game Over" debug message is displayed.

4. **Object Management**:
   - Dogs and balls are removed from the scene when they leave the screen.


## Features

- **Dynamic Player Control**: Players can move left and right using keyboard controls while remaining within bounds.
- **Projectile Launching**: Players can launch projectiles at animals using spacebar input.
- **Animal Interaction**: Animals spawn randomly in the scene and can be interacted with through projectile feeding.
- **Object Management**: Prefabs are used for efficient object management, allowing for easy instantiation and destruction of game objects.

## Getting Started

### Prerequisites
- Unity Hub installed with the 2018.4.24f1 version of Unity.
- Basic understanding of C# programming.

### Installation
1. Clone this repository:
   ```bash
   git clone https://github.com/FarnoodID/UnityAnimalFeeding.git
   ```
2. Open the project in Unity.
3. Ensure all necessary packages are installed.

