# First Year Game Development Portfolio

Welcome to my first year game development projects! This repository contains a collection of Unity games I created while learning C# and game development fundamentals. Each project demonstrates different gameplay mechanics, programming concepts, and creative problem-solving skills.

## 🎮 Games Overview

### 1. Pachinko Game
A physics-based pachinko machine simulation where players launch balls to score points.

**Features:**
- Ball launching mechanics (Left Alt / Right Alt)
- Physics-based ball movement with random force application
- Score tracking system (target: 1500 points to win)
- Ball counter (25 balls per game)
- Dynamic lighting effects
- Audio feedback
- Win/lose conditions

**Key Scripts:**
- `Pachinko.cs` - Main game logic and UI
- `FireBalls.cs` - Ball launching system
- `LanchBall.cs` - Ball physics and movement
- `Scores.cs` - Point scoring system
- `lights.cs` - Visual effects

### 2. Top-Down Car Racing Game
An action-packed 2D car game featuring shooting mechanics, collectibles, and exploration.

**Features:**
- Realistic car physics with steering and acceleration
- Shooting system with rotating turrets
- Collectible coins and key cards (Red, Blue, Yellow)
- Door lock system requiring specific key cards
- Lives system (3 lives per game)
- Camera following system
- Collision detection and damage
- Respawn mechanics

**Key Scripts:**
- `CarController.cs` - Vehicle movement and physics
- `Manager.cs` - Game state management
- `BulletScript.cs` - Projectile mechanics
- `Shoot.cs` - Turret shooting system
- `DoorLock.cs` - Access control system
- `KeyCard.cs` - Collectible items
- `CameraControll.cs` - Dynamic camera following

### 3. Horse Adventure Platformer
A 2D side-scrolling platformer featuring a horse character on a treasure-hunting adventure.

**Features:**
- Character movement with jumping mechanics
- Treasure collection system (3 treasures required)
- Enemy AI with flying enemies
- Lives system with visual indicators
- Hazard detection (traps, enemies)
- Audio feedback for actions
- Character face direction system
- Ground detection and physics

**Key Scripts:**
- `moving.cs` - Player character controller
- `Control.cs` - Game management and scoring
- `TresureCollect.cs` - Collectible treasure system
- `Flyingenemy.cs` - Enemy AI behavior
- `HellScript.cs` - Hazard mechanics
- `HorseAudio.cs` - Sound effects
- `DoorsOpen.cs` - Level progression

### 4. MasterMind Puzzle Game
A digital recreation of the classic code-breaking board game.

**Features:**
- Random color sequence generation (6 colors available)
- 12 attempts to guess the correct sequence
- Real-time feedback system
- Cheat mode for debugging
- Win/lose detection
- Color selection with number keys (1-4)
- Visual feedback with UI elements

**Key Scripts:**
- `MasterMind.cs` - Core game logic and UI management

## 🛠️ Technical Features

### Programming Concepts Demonstrated:
- **Object-Oriented Programming**: Class inheritance and encapsulation
- **Physics Systems**: Rigidbody2D, collision detection, force application
- **Audio Integration**: AudioSource and AudioClip management
- **UI Systems**: Canvas elements, Image arrays, Text components
- **Input Handling**: Keyboard and mouse input processing
- **Scene Management**: Scene transitions and game state persistence
- **Static Variables**: Cross-scene data persistence
- **Coroutines**: Time-based mechanics (implied through destroy timers)

### Unity Systems Used:
- 2D and 3D Physics
- Collision Detection (OnTriggerEnter, OnCollisionEnter)
- Transform manipulation
- Prefab instantiation
- Layer masks for ground detection
- Audio system integration
- UI Canvas system
- Scene management

## 🎯 Development Tools & Cheats

Several games include developer tools and cheat codes for testing:

- **Pachinko**: Debug lighting and score manipulation
- **Car Game**: 'C' key for unlimited resources and all key cards
- **Platformer**: 'C' key for enhanced jump height
- **MasterMind**: 'C' key to reveal the solution

## 🏆 Learning Outcomes

Through these projects, I gained experience in:

1. **Game Physics**: Understanding 2D physics, forces, and collision systems
2. **User Interface**: Creating functional game UIs with Unity's Canvas system
3. **Audio Integration**: Implementing sound effects and audio feedback
4. **Game State Management**: Handling lives, scores, and win/lose conditions
5. **Input Systems**: Processing player input for various control schemes
6. **Code Organization**: Structuring code with reusable components
7. **Problem Solving**: Debugging and implementing game mechanics from scratch

## 🚀 Getting Started

To run these projects:

1. Open Unity (2018.x or later recommended)
2. Import the project folder
3. Ensure all scripts are properly attached to GameObjects
4. Build and run individual scenes for each game

## 📝 Notes

These projects represent my first steps into game development and showcase progression from simple mechanics to more complex game systems. Each game demonstrates different aspects of Unity development and C# programming fundamentals.

---

*Created during my first year of game development studies - a foundation for future projects and learning.*
