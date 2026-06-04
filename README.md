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


## W7
1. The data came from the mesh. It stores color information on each vertex, and the Vertex Color node reads color information from it.

2. Unity blends the colors between nearby vertex, so the edges between colors look smooth.

3. Vertex color is less detailed because the color only exists on the vertrex of the mesh (limited by amount of vertrex of mesh), which is less detailed than store by pixels.
   Vertex color can use for simple coloring or stylized effects

4. I do not see anything wrong. The colors look smooth, if there were a problem, one area would color may mot match smoothy with nearby color

5. debug shader can help us see if the UV are stretched or be placed incorrectly.

6. The lighting looks wrong because the light direction and the surface normal is opposite. Therefore, the side that should be bright becomes dark, and the side that should be dark becomes bright.

7. Additive makes fire look bright, because it add on the background, which makes it like a real fire.


## W8

### Activity 1

1. Since Milestone 2, I adjusted the guard detection system, including the guard’s vision angle and detection distance. I also removed some unnecessary objects from the map to make the level cleaner, added colliders to some objects so the player and guards interact with the environment more correctly.

2. [Playtest](https://alex-dkc.itch.io/milstone)

3. My playtesting goals were to test the guard detection, attack, and chase systems. I also wanted to test the player weapon system, including switching weapons, aiming, shooting, and damaging enemies.

4.
  - The game should have a health bar or health UI, because right now the player cannot clearly know how much health they have left.
  - The shooting effect needs improvement. For example, adding muzzle flash, bullet impact, or stronger shooting feedback would make the weapons feel better.
  - Enemies need clearer hit feedback when they are attacked. Right now, it is hard to tell if the enemy was hit, so stronger impact feedback would make combat feel more satisfying.
  - After the player dies, the game should switch to a death screen or game over screen. Player input should also be disabled after death.
  
### Activity 2

1.It called FullScreenPassRendererFeature, because when I click this pass, the whole screen start has the red cobblestone texture overlay.

2. When the Lerp value is 0, the screen looks normal. When the value is 0.5, the red cobblestone texture is partly visible. When the value is 1, the red cobblestone effect is fully visible, the whole screen is strongly red.

3. The Lerp node blends between two inputs. The first input is the original game screen. The second data input (0-1) multiplied with the cobblestone texture.

4. result of sin(time)is -1 to 1, (sin(time)+1)/2 change its result to 0-1, So the effect smoothly changes from no effect to full effect

## W9

### Activity 1

Step 1: Our group chose Fruit Ninja.

Step 2: 
Effect 1: Moving Background Arrows

<img width="817" height="370" alt="截屏2026-05-27 下午6 50 03" src="https://github.com/user-attachments/assets/9dd07ace-8b7f-4d68-95bc-7d2ef47dafe8" />

The Arrows keep moving upward during the game. I think this effect is probably made with a material shader on the background, and it is not a full-screen effect. The shader may move the texture upward over time.

This effect is probably always active.
 As long as the background is visible, the arrows keep moving.

Effect 2: White Screen Flash

<img width="832" height="391" alt="截屏2026-05-27 下午6 53 28" src="https://github.com/user-attachments/assets/050fe6b3-4163-459b-9699-a631891bb579" />

Another effect is the white flash when the player slices many fruits. I think this is a full-screen post-processing effect. It affects the whole screen. The shader may blend the screen with white color. When the combo happens, the white color appear for a short moment. Then it quickly fades away.

This effect is activated by gameplay. When the player hits many fruits, the game triggers the flash effect.

### Activity 2

<img width="289" height="417" alt="截屏2026-05-27 下午6 41 45" src="https://github.com/user-attachments/assets/2efdf01a-a7c9-4ac6-b446-af492403d523" />
<img width="305" height="304" alt="截屏2026-05-27 下午6 27 59" src="https://github.com/user-attachments/assets/76c60256-01f4-4362-9359-9e3735445dcc" />
<img width="719" height="455" alt="截屏2026-05-27 下午6 42 30" src="https://github.com/user-attachments/assets/7f5edc54-aff8-4964-b0a1-6b591aec8795" />

I finished my Shader Graph for the damage screen effect. The effect is a full-screen shader. When the player gets hit, the screen shows a red vignette effect.At first, the effect did not show correctly because my project was not using the Universal Render Pipeline. To fix this, I changed the render pipeline to URP.

However, after switching to URP, some of my guard materials stopped working correctly. The textures became wrong or did not display properly. To fix this, I manually changed the guard materials to Lit(Universal Render Pipeline/). Then I reconnected the correct texture maps, such as the Base Map, Normal Map, Metallic Map. After doing this, the guards looked correct again under URP.

## W10
### Activity 1

1.What is new in my build since Milestone 2:
I added a damage ShaderGraph effect, arranged the guard positions and patrol routes, and added a new boss enemy with its own gameplay mechanic. The boss normally patrols, but after being attacked, it chases the player quickly and uses a close-range melee attack.

2.Itch page link:
https://alex-dkc.itch.io/milstone-0

3.Playtesting goal:
My main playtesting goal was to see how players reacted to the game difficulty. I wanted to know if the stealth route, guard placement, boss fight, and combat felt fair or too difficult.

4.Playtesting notes:
-The game felt too difficult. 
-Players also said there was not enough hit feedback, so it was sometimes hard to tell when the player or enemies were taking damage. 
-Another issue was that the game guidance was weak, so players were not always sure where to go or what the main objective was. 

### Activity 2
First, we would make a mood board to decide the visual style, atmosphere, and inspiration for the game. Then we would make a pitch that lists the main mechanics, theme, technical systems, and story/background of the game. After that, we would create a bubble diagram to show the main objects in the game, such as the player, enemies, weapons, UI, and level triggers. We would use lines to show how these objects connect, what functions they use, and what events trigger them. Finally, we would break down the project into smaller tasks. Each major system, like player movement, enemy AI, combat, UI, or shader effects, would become a task, and each task would be split into smaller steps. This makes the project easier to build because we know what to code first and how each part connects to the whole game.

I mean at first, game idea may sound complex or make do not know how to start, but when we draw diagrams and break it into systems, we can see how many small parts are actually needed. This helps us focus on the core gameplay loop. For example, instead of adding different mechanics randomly, we can focus on making movement, combat, stealth, and the ending work clearly first.

### Activity 3
Today I worked on polishing the gameplay balance and enemy behavior. I lowered the enemy attack damage because playtesters felt the game was too difficult. I also modified one type of enemy’s animation behavior. Before some of the guard being triggered, this enemy can now stand still in an upright idle pose.






  
