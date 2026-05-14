# GDIM 33 In-Class Activities
## W1
### Activity 1
[Google Paint1](https://docs.google.com/drawings/d/122QOKK0hZIUno_Q0jJ_vcVixD7VN3SM41nLzGfHJDic/edit)
   
1. I chose the card battle type of games, where players fight against NPCs and eventually defeat them. Players can use different cards to perform various actions, such as attacking, defending, etc. I was interested in games like Slay the Spire and Clash Royale and referred to them.
 
2. My tablemate chose a game similar to Left 4 Dead 2, which is about fighting zombies. The similarity between us is that we both chose games where we fight against NPCs, and we both have a dark style.
   
3. LA also enjoys this card-based battle game. He likes this type of game that relies on clear strategies. This is similar to me.


### Activity 2
<img width="1024" height="566" alt="image" src="https://github.com/user-attachments/assets/cc249cb5-abac-4998-96aa-c28d15058f6c" />



## W3
### Activity 1
<img width="1440" height="1652" alt="image" src="https://github.com/user-attachments/assets/6a55fe2e-7407-4de9-bdcd-28b93bb08569" />


### Activity 2

 1. This way, multiple different objects (such as walruses, penguins or other NPCs) can conveniently share the same "signal". If I want to modify the name of this event in the future, I only need to change it once in the Variables panel, without having to manually modify it in each Graph. This makes the code cleaner and reduces the possibility of errors.

 2. When I clicked on the walrus but the dialog box didn't pop up, Debug.Log helped me identify where the problem was. I added a Log after the click event on the walrus. If the information was displayed in the Console, it indicated that the click detection was fine, and the problem might be in the state machine transitions. It's like a "signpost", telling the code where it is in the execution process.

 3. Yes. In my Vertical Slice 3D or interactive games, when players are exploring, I need to lock the mouse (Locked) to control the perspective; but when players open menus or dialog boxes, I must release the mouse (None) otherwise players won't be able to click the UI buttons. Controlling the state of the mouse well can greatly enhance the gaming experience.

 4. Very relevant. My game also needs to distinguish different modes, such as "combat mode", "exploration mode", or "pause mode". Using game states (Game State) enables the game to run different logic at different stages (for example, pausing enemy movement during dialogue), which makes the overall logic management of the project very clear.


## W4
### Activity 1

1. My playable build now includes movement using the WASD keys, and there is also a flashlight function. Players can use the flashlight to see the scene in front of them clearly. I also designed the environment of the game, which consisted of a room with a floor, a ceiling and several walls. Players can move around inside and use the flashlight to observe the corridors and rooms. My playtesting goals are to figure out what I need to do next and how I should modify my game environment.

2. OKADA Naoma, Thomas Sun, Beiduo Jin

3. The environment is a bit giddy. The lighting is too dim. It should be adjust later. In addition, more rooms can be added.

### Activity 2

1. Under the current system settings, writers can easily add more dialogues without writing any code. This is because all the dialogue content, response options, and the logic for their transitions are stored in a ScriptableObject (i.e., the DialogueNodeW4 file). Writers only need to create a new file in the Unity editor by right-clicking, and inputting text and dragging connections between different nodes as if filling out a form. The system can automatically recognize and generate new content based on the logic we have written.

2. There are no strict limitations. As long as the computer's memory and hard disk space are sufficient, the writer can create hundreds or even thousands of nodes to build a vast story network. The only actual limitation might come from the UI level, where buttons might extend beyond the screen boundaries. However, this is a limitation in visual design rather than a limitation of the dialogue system itself.

3. The "Regenerate Nodes" button functions much like a "mirror" for Visual Scripting, allowing it to re-scan all the code within the project. This is because when you add new variables (such as visual effect prefabs) in the C# script, the Visual Scripting node library does not automatically update in real-time. By clicking this button, the system is forced to refresh the node list, converting the changes we made in the code into searchable and usable visual nodes.

4. <img width="775" height="467" alt="image" src="https://github.com/user-attachments/assets/ccd60248-f648-47c3-b4aa-6d2657880f64" />

## W5
### Activity 1

#### 1. Step 1: Data Architecture (Least Complex)
The goal is to create the "container" for our information so the game has a place to pull data from.

Substep 1: Create a C# script named InstructionData.cs that inherits from ScriptableObject.

Substep 2: Define two public string variables: title and content.

Substep 3: Create a new Asset in the Project window using this script (e.g., "Level1_Book") and type in sample text.

Test: Select the asset in the Inspector; if you can see and edit the "Title" and "Content" fields, this step is working.

#### 2. Step 2: Logic and Data Retrieval (Medium Complex)
The goal is to make the Player "aware" of the data and prove we can access it via code.

Substep 1: In the Player’s Script Machine, create an Object variable named currentData to hold the ScriptableObject.

Substep 2: Regenerate nodes in Project Settings so Visual Scripting can "see" the new C# variables.

Substep 3: Use a "Get Variable" node for currentData and connect it to a "Get Title" node.

Substep 4: Connect the output of "Get Title" to a "Debug Log" node.

Test: Run the game; if the console prints the correct title from the asset, the data bridge is successful.

#### 3. Step 3: UI Integration and Display (Most Complex)
The goal is to push the retrieved data onto the actual game UI for the player to see.

Substep 1: Create Scene variables for the Title and Content TextMeshPro objects in the Blackboard.

Substep 2: Use the TextMeshProUGUI: Set Text nodes to receive the strings from the ScriptableObject.

Substep 3: Connect the execution flow (green arrows) from the start event through both Set Text nodes.

Substep 4: Troubleshoot the "Missing Target" error by verifying the Set Text node matches the UGUI component type.

Test: Run the game; if the UI panel on screen updates to show the custom "Title" and "Content," the feature is complete.

### Activity 2 

   While building the feature today, I ran into a frustrating issue where the UI refused to update and kept throwing a "Missing Target" error. To find the bug, I had to use a lot of trial and error. I spent a long time connecting and disconnecting different logic wires to isolate exactly where the break was happening. I noticed that while the "Title" part of the system seemed to work fine in some tests, the "Content" section would often cause the whole system to fail.

   After carefully comparing my nodes and testing different versions of the same command, I finally discovered the root cause: I was using the wrong version of the Set Text node. In Unity, there is a version for 3D objects and a version specifically for UI elements called TextMeshProUGUI. Because these nodes look almost identical in the graph editor, I had accidentally picked the 3D one. By systematically disconnecting my variables and testing them one by one, I was able to identify the mismatch. Once I replaced the nodes with the correct UGUI versions and cleaned up my wiring, the text finally displayed perfectly. Finally, I completed the scripting of the scriptable object and modified the UI so that when players click different keys, they would be redirected to different interfaces.

## W7
1. Is from 3D model resource file

2. Because the GPU performed interpolation. The shader will automatically calculate a transitional color for each pixel within the polygon based on the color values of the three vertices of the triangle.

3. The vertex coloring has poor details because its resolution is limited by the number of model faces (only areas with vertices have color data); while textures can define details at each pixel. Vertex colors do not occupy additional texture memory and are suitable for optimizing performance and adding color variations to large areas of the environment.

4. The normal direction of the vertices of the grid is incorrect.

5. In addition to the normal vector, we can also visualize the UV coordinates. By mapping the U and V components of the UV onto the red (R) and green (G) channels respectively, we can check for any stretching, distortion or misalignment in the texture by observing the smoothness and arrangement of the colors. This can be used to detect if there are any alignment issues with the model.

6. It is due to the logical reversal of the dot product. The default direction vector of the light ray points from the light source to the object, while the normal vector points outward from the object; when the light ray is directed towards the front, the two vectors are in opposite directions, and the dot product is negative (turning black). Therefore, we need to multiply the light vector by -1 to reverse the direction.

7. In step (6), the flame is set to the "Additive" mode because this mode directly adds the pixel color values of the flame to the background color. Since the flame is a luminous object, additive blending makes the overlapping parts brighter, perfectly simulating the visual effect of the flame, and also eliminating the hassle of handling complex occlusion relationships.
