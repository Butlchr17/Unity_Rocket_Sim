# Rocket Launch Simulator

## Overview
This Unity project is a 3D rocket launch simulator designed to develop skills relevant to entry-level software engineering roles . The simulator features a rocket with user-controlled thrust and rotation, physics-based movement, real-time UI feedback, and data logging to a CSV file for post-simulation analysis. Built using C# in Unity, with version control managed via Git/GitHub, it demonstrates proficiency in real-time systems, physics integration, and data handling.

## Features
- **Interactive Controls**: Adjust thrust via a UI Slider and Space key; rotate with W/S (pitch) and A/D (yaw).
- **Physics Simulation**: Uses Unity’s Rigidbody for realistic movement under thrust and gravity.
- **Visual Feedback**: ParticleSystem for thrust visuals and a UI Text element displaying real-time position (X, Y, Z) and velocity (X, Y, Z).
- **Data Logging**: Outputs time, position, and velocity to `trajectory.csv` at 0.1s intervals.
- **Camera System**: Third-person camera follows the rocket dynamically.

## Prerequisites
- **Unity**: Version 2022 LTS or later, installed via Unity Hub.
- **C# IDE**: Visual Studio or VSCode with C# support (Unity integrates with Visual Studio by default).
- **Git**: Installed on your system (e.g., `sudo apt install git` on Debian).
- **Basic Unity Knowledge**: Familiarity with Unity’s interface recommended (see Unity Learn for beginner tutorials).

## Setup Instructions
1. **Clone the Repository**:
   ```bash
   git clone https://github.com/yourusername/unity-rocket-simulator.git
   cd unity-rocket-simulator
   ```
2. **Open in Unity**:
   - In Unity Hub, click "Add" and select the cloned project folder.
   - Open the project and load `Assets/Scenes/MainScene`.
3. **Configure Components**:
   - **Rocket (Cube)**: Attach `RocketController.cs`, `DataLogger.cs`, and a Rigidbody. Assign a ParticleSystem (child, at base) to `burn` and a UI Slider to `thrustSlider`.
   - **Canvas**: Ensure a UI Slider (`thrustSlider`) and Text (`statusText`) are present.
   - **CameraRig**: Attach `CameraFollow.cs` to an empty GameObject with the Main Camera as a child; assign the Rocket as `target`.
4. **Verify Assignments**:
   - In the Unity Inspector, ensure `burn`, `thrustSlider`, `statusText`, and `target` are linked to their respective components.

## How to Run
1. Open `MainScene` in Unity Editor.
2. Press Play to start the simulation.
3. **Controls**:
   - **Space**: Apply thrust (magnitude set by `thrustSlider`, 0-1 range).
   - **W/S**: Pitch up/down.
   - **A/D**: Yaw left/right (or use arrow keys).
4. **Outputs**:
   - **UI**: Real-time display of position (X, Y, Z) and velocity (X, Y, Z) on the Text element.
   - **CSV**: On quitting (Stop in Unity), `trajectory.csv` is saved to `Application.persistentDataPath` (e.g., `~/Library/Application Support/...` on macOS, check Debug Log for path).
   - CSV format: `Time,PosX,PosY,Posz,VelX,VelY,VelZ`.

## Project Structure
- **Assets/Scenes/MainScene**: Contains Rocket (Cube), Ground (Plane), CameraRig, and Canvas with UI elements.
- **Assets/Scripts**:
  - `RocketController.cs`: Manages thrust, rotation, particle effects, and UI updates.
  - `CameraFollow.cs`: Implements third-person camera tracking.
  - `DataLogger.cs`: Logs position and velocity to CSV at 0.1s intervals.
- **trajectory.csv**: Generated on application quit (not tracked in Git; check `Application.persistentDataPath`).

## Sample Output
Example `trajectory.csv` snippet:
```
Time,PosX,PosY,Posz,VelX,VelY,VelZ
0.1,0.00,0.05,0.00,0.00,0.49,0.00
0.2,0.00,0.20,0.00,0.00,0.98,0.00
...
```

## Extending the Project
- **Collision Handling**: Add ground detection (e.g., stop rocket if `pos.y <= 0`) in `RocketController.cs`.
- **Fuel System**: Implement fuel consumption to limit thrust duration, simulating real rocket constraints.
- **Data Analysis**: Import `trajectory.csv` into Python (e.g., pandas/matplotlib) to plot trajectories or detect anomalies.
- **Visual Polish**: Add rocket model or enhanced particle effects for portfolio appeal.

## Performance Notes
- Optimized for Unity 2022 LTS with lightweight physics and minimal particle effects.
- Use Unity Profiler (Window > Analysis > Profiler) to monitor performance; adjust `logInterval` in `DataLogger.cs` if needed.
- Tested for smooth execution with real-time UI and CSV logging.

## Version Control
- Commits on `main` include setup, physics/controls, UI/data logging, and polish.
- Optional `feature/advanced-controls` branch adds W/S pitch controls (merged).
- Tagged as `v1.0` for release: `git tag v1.0 && git push --tags`.

## Purpose
This project builds skills for:
- C# programming for real-time systems, physics integration, and user input handling
- Data logging and CSV output for data pipeline preprocessing
- Demonstrates clean code, version control, and real-time simulation
