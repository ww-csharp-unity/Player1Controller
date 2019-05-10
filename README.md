# Player1Controller
A controller script designed to gather inputs from an Xbox 360 controller and return them to the Unity game engine.

This set of scripts works by getting the input from an Xbox 360 controller via the Player1Controller script. That input triggers a public boolean. Those booleans are then checked by various scripts specific to the individual buttons on the controller.

IE: AButton.cs checks Player1Controller to see if the A button bool is true. If it is, it generates a visual response in the game engine at a random location on the screen.
