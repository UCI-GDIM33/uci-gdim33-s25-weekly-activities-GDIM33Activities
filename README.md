# GDIM 33 In-Class Activities
## W1
### Activity 1
1. [Inspo Board](https://docs.google.com/drawings/d/1bSd9mM2_ybX37DnfCJqedw7JUDQVw5YhKuckTEp30CI/edit?usp=sharing)

2. 
    - Patterns: a lot of platformers (Rain World, Hollow Knight, William and Sly 2), as well as relatively-simplistic looking artwork (West of Loathing, Stickfigures, Poptropica) and nonserious, silly atmospheres.
    - My tablemates like roguelikes; some roguelikes have simplistic artstyles (eg: Binding of Isaac, Brotato) similar to some of the games I like.
    - Our LA (Leah) likes RPG games like Undertale; RPGs aren't my favorite genre but I definitely did enjoy Undertale.

### Activity 2
![breakdown](https://github.com/user-attachments/assets/b1162a65-d342-4f88-a098-837df44267b3)

<hr>

## W2
Visual Scripting: 
<img width="1462" height="1321" alt="image" src="https://github.com/user-attachments/assets/e02c3b9f-09e3-447a-89d9-36c71cee7d3e" /> <br>
Grow every frame, on trigger touch (egg), play the confetti VFX <br>

<img width="1369" height="1288" alt="image" src="https://github.com/user-attachments/assets/48444b73-0d90-468e-813c-e8c96f6f2e10" /> <br>
Left/right arrow keys: movement

<img width="2014" height="610" alt="image" src="https://github.com/user-attachments/assets/b3372bf0-48a1-4384-9a12-9d2c731970b5" /> <br>
Press space: increment a counter; then Debug.Log {counter} numbers of the Fibonacci sequence.

<hr>

## W3
### Activity 1
<img width="1771" height="859" alt="breakdown3" src="https://github.com/user-attachments/assets/afd025b3-3413-4475-a5b5-eb529cb472a1" />

<!-- NOTE TO SELF: DO THE DEVLOG QUESTIONS -->
### Activity 2
1. It's convenient to save event names as Scene variables because then you don't have to type the name of the event every time another Graph wants to call the event, and if you change the event name, you don't have to change all the calls either.
2. I actually noticed my Trigger Custom Event node wasn't working because I forgot to hook up the source GameObject to the node. I noticed this because the Debug.Log in my Transition node wasn't firing.
3. I'm coding a 2D platformer with a mouse-controlled sticky hand attached to the player, so I think locking the cursor would actually be detrimental to the gameplay. I could hide the cursor if it was distracting, but locking it I think would just not work, as I need the sticky hand to constantly seek out and move towards the mouse position.
4. I don't think my game has any 'game state'. I don't intend on putting any dialogue or other 'states' that would pause movement of certain GameObjects. I could put instructions in the background of the level, but it wouldn't have any effect like the dialogue state in this week's activity.

<hr>

## W4
### Activity 1
Playtesting Plan<br>
Goal: see if movement is smooth and if controls are intuitive

Playtest team: Eli, Minjoo, Milla<br>
Notes: movement and collisions are smooth, good proof of concept, hoping for way to put down object soon

### Activity 2
1. Yes, a writer can add more dialogue w/out writing code because all they have to do is create new ScriptableObjects and hook the Dialogue Nodes up to each other in the Unity Editor, without ever having to look at the code.
2. No limit, besides project size probably...
3. Regenerate Nodes generates a file that stores information about how code (your own + Unity's) is displayed in the Visual Scripting interface.

Bonus Point: I added a VFX that is played every time a button is clicked.
<img width="1550" height="870" alt="bonuspoint" src="https://github.com/user-attachments/assets/f2b998e9-563e-4ff1-8dd0-acebf8836db6" />

<hr>

## W5
### Activity 0
Unity tool: Animator

### Activity 1
Since I've already implemented an Animator for the PlayerController, so I will implement TileMap for my platformer's levels instead.

Building plan:
1. Get a basic set of tiles (only one kind, no variant) working in Unity.
  - Import tiles and slice them. Check the sliced sprites to see that they are the expected size (no cut-off tiles, stray pixels from other tiles, etc).
  - Add colliders and build a simple level (ideally using every tile so each tile can be tested). Test the collision using the player. Good collision should prevent the player from falling through the level, and match the visual appearance of the tiles.
2. Import tile variants for visual detail (eg: other tiles, animated tiles, etc).
  - Import tiles and slice them. Check the sliced sprites for correctness
  - Add colliders, test again
  - For tiles that blend together, test blending rules by placing blending tiles together and ensure they are being drawn as intended

### Activity 2
I imported a basic tile, wall, and paintile, replacing the old level pieces (~10 SpriteRenderer GameObjects) with 3 Tilemap GameObjects. This will make it a lot easier to add onto and build new levels in the future.

<img width="1483" height="810" alt="image" src="https://github.com/user-attachments/assets/4db0ac14-9d0e-4750-9eea-88fe4d6215a8" />
Pipe walls for the future, maybe a parallax background? :)

<hr>

## W6
### Activity 1
New (visible) features: you can now drop items, aim and fire the gun, aim and throw items like boxes.<br>
[Link](https://sunrd.itch.io/adventure-of-a-sticky-hand-playtest2)<br>
Playtesting goal: See if movement is smoother than last week's... also find bugs (particularly in the sticky hand. bane of my existence)<br>

Feedback: player gets stuck on platform corners (completely halts), bit hard to control ('slippery'). Boxes slip around weirdly when on their sides (maybe due to Platformer Effector?)

### Activity 2
1. Multiply makes colours darker and less saturated because the setting multiplies the values of the input vectors, which will result in smaller values since we store the colour channels as decimals (0.0-1.0). The numbers can only get smaller, and RGB 0,0,0 = black, so all multiplications of colours will result in getting closer to black.
2. The resultant colour will be more transparent, by the same logic in Question 1. For example, Alpha 0.8 * Alpha 0.4 = Alpha 0.32 (even more transparent than either 0.8 or 0.4)
3. UV values are stored in vertex data, so this data is from the mesh.
4. A bit. It sounds kinda nerdy, but honestly kinda cool...
