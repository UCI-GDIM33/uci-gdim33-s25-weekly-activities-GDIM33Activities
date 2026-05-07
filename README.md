# GDIM 33 In-Class Activities
## W1
### Activity 1
[Activity 1: brainstorm](https://docs.google.com/drawings/d/1ugxKbuKLlBbpqZvrLtJKdx3I6zAFIf1qCySLS28vePc/edit)
1. A clear pattern in my inspiration is my interest in inequality, oppression, and the lives of ordinary people under powerful systems. I want to combine a post-cyberpunk world with the class suffering and emotional intensity of Les Misérables, mixing advanced technology with poverty, control, and resistance. In terms of gameplay, I am most interested in fight and exploration
2. My classmate wants to make a cyberpunk survival horror game with a big story. Our styles are similar because we both like  strong atmosphere in game world. her game is more about horror, while mine is more about depict social pressure and unfair systems.
3. One LA said they are interested in making a multiplayer PvP shooting game. Our ideas are similar because both of us are interested in shooting elements. his game focuses more on competition between players, while mine uses shooting more as part of the world, conflict, and story.



### Activity 2
[Activity 2: break-down](https://docs.google.com/drawings/d/1NqhMj7zMddQUyuUmfBft3l2naNNAFNeYzsN6Gl916Xo/edit?usp=sharing)


## W3
Activity 1，[Break-down](https://docs.google.com/drawings/d/1NqhMj7zMddQUyuUmfBft3l2naNNAFNeYzsN6Gl916Xo/edit?usp=sharing)

Activity 2，

  1, It is because the same event name can be reused in different Graphs. If you want to change name, it only need to change it in one place. 
  
  2, Debug.Log() helped me check if one of the event in the graph was being triggered correctly in the whole system.
  
  3, Yes, My game has both normal movement and UI interface such as mission failing page, or pause page or inventory page, so locking and unlocking the cursor can help control when the player moves and when they use UI or inventory.
  
  4, Yes, in my game, the guards would have at least two states: a patrol state and an alert state. In the patrol state, the guard moves around in the area. In the alert state, the guard chases the player or attacks and shoots at the player.

## W4
Activity 1

I complete the move function of the player, use WASD and mouse to control the charactor.

Goal：testing if a movement of player feels smooth 

  1. the animation is not finished, and sometimes the character still appears to move even when no keys are being pressed （Yan Zhang）
     
  2. the movement speed feels too slow, so I need to adjust it to make the controls feel better. （JingyiBi）
     
  3. when the player stops pressing WASD, the character snaps back to a default direction. （Tina Meng，Xichan Zheng）


Acticity2,

1，Yes, a writer could add more dialogue without writing code. After the system is set up, they can just create more dialogue node, write lines and add reply options in the Inspector. The code and graph already handle the logic.

2, The writer can create as many dialogue layers. The limit is the UI, because the screen can only fit about 4 reply options.

3, The Regenerate Nodes button updates the Visual Scripting node library so Unity can recognize new C# code, methods, and events as nodes.

## W5

activity1:

Step 1: Build the basic weapon switching state system

  Create two player states in the Visual Scripting State Machine: Unarmed and PistolEquipped.
  
  In the Unarmed state, keep the pistol hidden.
  
  In the PistolEquipped state, make the pistol visible.
  
  Add transitions between Unarmed and PistolEquipped using the Tab input.
  
Step 2: Add aiming behavior inside the pistol-equipped state

  Use the right mouse button input to detect when the player is aiming.
  
  Connect the aiming input to the Animator through the isAiming
  
  Using IF -> While aiming, lock the player’s movement input but keep camera movement active.
  
  When the right mouse button is released, means False, player back to the normal pistol-equipped pose.
  
Step 3: the draw-gun animation 

  set up varaible in the paramaters

  Find pistol idle, pistol draw, and poistol drop animation
  
  Adjust the pistol position so it looks correct in the player’s hand.
  
  connect the animation loop: idle - equip pistol - pistol idle - unequip pistol - idle

  set the condition of the transition of the animation


activity 2
  
For Activity 2, I had already set up some variables in my C# script before class. During class, I first created matching variables in the Animator, and then I mainly worked on building the logic in Visual Scripting based on those variables, especially using a state machine to control the two main states: unarmed and pistol-equipped.This part went fairly smoothly, but later I had trouble connecting the Animator. Player cannot transform to idle state. Finally, I find out it is because one variable could not be trigger, and then I found that I was missing a line related to a bool in the script. In the end, I fixed that, and the animation works smoothly.


## W6
### Activity 1
1, I added an enemy movement system. The guards can now patrol between points, chase the player, and shoot when the player is close enough. I also continued improving the player systems, including aiming, camera movement, and weapon-related state changes.

2，[Game Itch page](https://alex-dkc.itch.io/milstone2)

3, My playtesting goals: I want to test whether the enemy movement system feels smooth and whether the player movement system also feels smooth during gameplay. I especially want to see if the guard patrol, chase, and shooting behaviors work in a clear and believable way.

4, comments from playtesters:

  -There are some clipping problems between characters and objects.
  
  -The map does not give enough guidance, so the player may not know where to go.
  
  -After one guard finishes an animation, it sometimes keeps spinning in circles.


### Activity 2

1, Multiplysetting of the Blend node make the resulting colordarker and less saturatedthan the input colors because it multiplies each RGB  value, and those values are between 0 to 1. Therefore, multiply two numbers in that range, the result is  smaller, for example 0.1* 0.2 = 0.02, so the color becomes darker

2, same as the RGB value, Alpha values multiply with each other will get a smaller value. In Aplha balue, 0 is translucent, 1 is not translucent. Therefore, a smaller alpha of the output value means more translucent

3, The shader get the UV values from the mesh. The model already stores UV coordinates, and the shader use the data to find which color or texture to use.

4, Yes, I know the reason of the changes of color



  
