# HARDWARE PUZZLE

This project was started by an AR/VR Community of Practice as a fun way for the members to learn about AR development. The aim of the “Hardware Puzzle” application is to provide an interactive way to learn about computer hardware components. It is an augmented reality application for mobile devices which allows the user to learn about hardware components, their functions, and how they fit together. Users can “scan” for the different hardware components ( CPU chip, RAM module, motherboard, etc ), by pointing the device’s camera at the physical parts which would be on display. When a component has been “scanned”, a description of the it is displayed on the device’s screen. Once all the components have been scanned, the user can drag and drop them onto the motherboard, where their correct position will be shown. The application was developed using Unity Game Engine and the Vuforia platform for AR development.

## CURRENT PROGRESS

The initial tool setup for the project included installing the Unity game engine and registering with Vuforia to get a development licence key and enable the integration with Unity. The first stage of the development process was the creation of a database of Vuforia Model Targets for the computer parts, using the Vuforia Object Scanner application. The database has to be imported into the Unity project to allow the targets to be recognised through the camera. Once this stage was complete, the team moved on to the creation of the UI. A stylish introductory screen was added which allows the user to navigate to the “scan” screen. On the “scan” screen, users can point the camera to the components and speech bubbles were added to display information for the hardware components once they are recognised by the application.

## FUTURE WORK

For the minimal viable product to be complete, the team aims to add 3D objects to the Unity application which the user will be able to drag and drop to “assemble” the computer, after all components have been “scanned”. The inventory screen would also be populated with all the parts that have been “scanned”.

Additional features have been suggested to gamify the experience, such as a timer to track how long it takes for users to complete the “assembling” stage with a leaderboard; or an “end-game” quiz to test the user’s knowledge on the parts, based on the information presented in the text “bubbles”.

## REFERENCES

Repo - https://github.com/christos-giallouros/shipit/tree/master/Assets

Unity Game Engine - https://unity3d.com

Vuforia - https://www.vuforia.com

Vuforia Object Scanner - https://library.vuforia.com/articles/Training/Vuforia-Object-Scanner-Users-Guide


