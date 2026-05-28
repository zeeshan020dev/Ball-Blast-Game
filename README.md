<h1 align="center">Ball Blast Game</h1>

<p align="center">
	<strong>Arcade action, score chasing, and clean Unity gameplay systems.</strong>
</p>

<p align="center">
  <img src="https://img.shields.io/badge/Unity-3D Arcade-ffffff?style=for-the-badge&logo=unity&logoColor=white&labelColor=0d1117" />
  <img src="https://img.shields.io/badge/C%23-Gameplay Logic-239120?style=for-the-badge&logo=csharp&logoColor=white&labelColor=0d1117" />
  <img src="https://img.shields.io/badge/License-MIT-00c9ff?style=for-the-badge&logo=opensourceinitiative&logoColor=white&labelColor=0d1117" />
  <img src="https://img.shields.io/badge/Open Source-Yes-22c55e?style=for-the-badge&logo=github&logoColor=white&labelColor=0d1117" />
  <img src="https://img.shields.io/badge/Status-Portfolio Project-22c55e?style=for-the-badge&logo=rocket&logoColor=white&labelColor=0d1117" />
  <img src="https://img.shields.io/badge/Engine-Unity 2021.3+-ffffff?style=for-the-badge&logo=unity&logoColor=white&labelColor=0d1117" />
</p>

<p align="center">
	Built for a clean portfolio-style GitHub presentation with gameplay, UI, and scene-management systems.
</p>

---

## 🃏 Feature Cards

| | |
| --- | --- |
| **🎯 Responsive Controls**<br>Horizontal movement feels immediate and is clamped inside the play area. | **🔥 Arcade Combat**<br>Fire projectiles, destroy enemies, and keep the action moving. |
| **🧠 Clean Game Flow**<br>Start, pause, resume, restart, and game over states are managed centrally. | **💥 Hit Feedback**<br>Explosion particles and sound effects give every hit impact. |
| **📊 Score & Health UI**<br>TextMesh Pro keeps the HUD readable and polished. | **🧩 Reusable Systems**<br>Spawner, player, projectile, and menu logic are separated into focused scripts. |

## Table of Contents

- [Project Overview](#-project-overview)
- [Gameplay GIF](#-gameplay-gif)
- [Feature Cards](#-feature-cards)
- [Features](#-features)
- [Gameplay Mechanics](#-gameplay-mechanics)
- [Controls](#-controls)
- [Technologies Used](#-technologies-used)
- [Unity Version Compatibility](#-unity-version-compatibility)
- [Folder Structure](#-folder-structure)
- [Installation and Setup](#-installation-and-setup)
- [How to Play](#-how-to-play)
- [Scripts and Modules](#-scripts-and-modules)
- [Screenshots](#-screenshots)
- [Future Improvements](#-future-improvements)
- [Contribution Guidelines](#-contribution-guidelines)
- [License](#-license)
- [Author](#-author)

## 🎮 Project Overview

**Ball Blast Game** is a Unity-based arcade project inspired by the ball-blast genre. The core loop is simple and responsive: move horizontally, fire projectiles, eliminate enemies, and stay alive as long as possible while the score climbs. The project is intentionally lean, making it a strong open-source portfolio example for gameplay scripting, scene setup, prefab workflows, and UI-driven game state management.

The repository contains a single playable scene, reusable prefabs, TextMesh Pro UI, sound and particle feedback, and a small set of focused scripts that separate responsibility cleanly across player movement, enemy spawning, collision handling, scoring, health, and menus.

## ✨ Features

- Fast arcade gameplay with immediate restart/pause flow.
- Horizontal movement constrained to the arena bounds.
- Projectile spawning with audio feedback.
- Enemy spawning on a timer at randomized X positions.
- Score and health tracking through a central game manager.
- Game over state with time freeze.
- Start menu and pause menu UI.
- Explosion particles and hit sounds for impact feedback.
- TextMesh Pro UI for crisp in-game text rendering.

## 🕹️ Gameplay Mechanics

| Mechanic | Behavior |
| --- | --- |
| Movement | The player moves left and right with horizontal input and is clamped inside the play area. |
| Shooting | Press **Space** to spawn a projectile from the player position. |
| Enemies | Enemies spawn repeatedly after a short delay at random X positions. |
| Collision | Projectiles destroy enemies, and enemies that reach the player reduce health. |
| Scoring | Destroying enemies adds points to the score. |
| Health | The player begins with 3 health; reaching zero triggers game over. |
| Menus | The game opens on the start menu and supports pause, resume, restart, and quit actions. |

## 🎯 Controls

| Input | Action |
| --- | --- |
| A / D or Left / Right | Move the player horizontally |
| Space | Fire a projectile |
| Escape | Pause or resume the game |
| Mouse / UI buttons | Start, restart, resume, or quit through the menus |

## 🧰 Technologies Used

| Technology | Purpose |
| --- | --- |
| Unity | Game engine, scene management, physics, and prefab workflow |
| C# | Gameplay, UI, input, and menu logic |
| TextMesh Pro | Score, health, and menu text rendering |
| Unity Physics | Trigger-based collision detection |
| Particle System | Explosion and hit feedback |
| AudioSource / AudioClip | Shooting and hit sound effects |
| SceneManager | Reloading the active scene for restart flow |
| Unity Input Manager | Runtime movement and firing controls used by the scripts |
| Input System asset | Included in the repository for future input expansion |

## 🧩 Unity Version Compatibility

The repository snapshot does not include `ProjectSettings/ProjectVersion.txt`, so the exact editor version cannot be confirmed from the source tree alone.

| Compatibility | Notes |
| --- | --- |
| Recommended | Unity 2021.3 LTS or newer |
| Expected support | Recent Unity LTS releases with TextMesh Pro and standard 3D physics |
| Notes | The current scripts use classic input methods, while the repo also includes an Input System action asset |

## 📁 Folder Structure

| Path | Description |
| --- | --- |
| `Scenes/` | Main playable scene (`SampleScene.unity`) |
| `Prefabs/` | Enemy, projectile, and explosion prefabs |
| `Materials/` | Materials for the game objects and environment |
| `2D Space Backgrounds/` | Background art assets used for the scene look |
| `Sprites/` | Sprite assets for visual elements |
| `TextMesh Pro/` | TMP fonts, resources, shaders, and settings |
| `EnemySpawner.cs` and other root scripts | Core gameplay, collision, UI, and menu logic |
| `InputSystem_Actions.inputactions` | Input System action asset included with the project |
| `_Recovery/` | Unity recovery data generated by the editor |

## 🚀 Installation and Setup

1. Clone or download the repository.
2. Open the project folder in **Unity Hub**.
3. Use **Unity 2021.3 LTS or a newer compatible version**.
4. Open `Scenes/SampleScene.unity`.
5. Allow Unity to import TextMesh Pro and any required package dependencies.
6. Press **Play** to launch the game.

If references are missing after opening the scene, check the inspector assignments for `GameManager`, `MenuManager`, `PlayerMovement`, and `EnemySpawner`.

## ▶️ How to Play

1. Click **Start** on the main menu.
2. Move left and right to dodge incoming enemies.
3. Press **Space** to fire projectiles.
4. Destroy enemies before they reach you.
5. Watch score and health in the HUD.
6. Press **Escape** to pause or resume.
7. When health reaches zero, the game shows **Game Over** and pauses time.

## 🧠 Scripts and Modules

| Script | Responsibility |
| --- | --- |
| `PlayerMovement.cs` | Reads horizontal input, clamps the player to the arena bounds, spawns bullets, and plays shoot audio. |
| `MoveForward.cs` | Moves projectile objects forward each frame. |
| `EnemySpawner.cs` | Instantiates enemy prefabs at random X positions on a repeating timer. |
| `Enemy.cs` | Moves enemies toward the player and applies score/damage handling on collision. |
| `DestroyOnContact.cs` | Alternate hit-response script that plays explosion and sound effects when a projectile collides. |
| `GameManager.cs` | Tracks score and health, updates the HUD, and triggers the game over state. |
| `MenuManager.cs` | Handles start, pause, resume, restart, and quit behavior through the UI. |
| `HealthSystem.cs` | Lightweight health helper kept in the project for reusable or legacy health logic. |

## 📸 Screenshots

Add screenshots here to complete the repository presentation.

| View | Placeholder |
| --- | --- |
| Main Menu | Add a screenshot of the start screen |
| Gameplay | Add a screenshot of active gameplay |
| Game Over | Add a screenshot of the game over state |

## 🔮 Future Improvements

- Add progressive difficulty scaling.
- Introduce multiple enemy types with distinct behavior.
- Add power-ups such as spread shot, shield, or rapid fire.
- Store and display a high score.
- Improve visual polish with hit flash, screen shake, and transitions.
- Add mobile-friendly touch controls.
- Expand audio with background music and layered sound effects.
- Create separate menu and gameplay scenes for a more production-ready flow.

## 🤝 Contribution Guidelines

Contributions are welcome. To keep the project clean and easy to review:

- Fork the repository and create a feature branch.
- Keep changes scoped and readable.
- Test gameplay changes inside Unity before opening a pull request.
- Update the README if controls, systems, or setup steps change.
- Prefer small, focused commits.

## 📜 License

This project is licensed under the **MIT License**. See the [LICENSE](LICENSE) file for the full text.

## 👤 Author

**[Muhammad Zeeshan Islam](https://github.com/zeeshan020dev)**  

<a href="https://github.com/zeeshan020dev">
  <img src="https://img.shields.io/badge/GitHub-zeeshan020dev-ffffff?style=for-the-badge&logo=github&logoColor=white&labelColor=0d1117" />
</a>

- Unity game developer portfolio project
- Built with Unity and C#
