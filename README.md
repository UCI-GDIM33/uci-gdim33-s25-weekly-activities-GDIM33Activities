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

<hr>

## W7
1. The data for the vertex colour node comes from the vertex data stored in the mesh.
2. Because we only have colour data for the vertices, to get colour for areas between the vertices, we interpolate between the vertices' colours, which makes the colours appear to blend between vertices.
3. Textures allow for the illusion of depth and detail when the underlying mesh is simple, which allowed for last week's shiba to have a mouth. Colour only does what it says on the tin, so there is no depth (or mouth) for this week's shiba, making it look very flat...
4. Yeah, there seems to be a little patch of colour looking out of place on the shiba's left hindleg.
5. We could check the UV data. Incorrect UV data would make textures draw weirdly, and it might be helpful to see if some and which vertices have incorrect UV data.
6. The lighting error is due to the odd patch we discovered in the NormalDebug shader, likely a few vertices that have incorrect normal data.
7. We set the blend mode to Additive because Multiply would just make the colours darker and duller, while Additive would make the colours brighter, which is desirable for a fire effect.

<hr>

## W8
### Activity 1
Playtest feedback:
- Putting the keyhole above the door makes it seem like the key should be put on the keyhole rather than the door
- The gun fires strangely at certain held angles (bug)

### Activity 2
Activity chosen: 2A (outline and cel shading)
1. The stencil buffer is being used to write where the shiba is (always write 1). This is done first, and then after this, the outline reads the buffer to see where the shiba is. Wherever the shiba *isn't* (not equals 1 in the Renderer Feature settings!), the outline is drawn.
2. StencilWritePass and DrawOpaqueObjects make no visible difference to the shiba. It's being drawn twice because the first time we're writing to the stencil buffer, and the second time is the usual draw pass.
3. We add the results because for both results, part of the preview sphere is black (0 0 0). If we multiplied the colours of these spheres, we'd get a lot more black, when really we want the non-black parts to combine.
4. Changing the layer the shiba is on toggles the outline effect because we set the outline effect to only draw on the Outline layer.

<hr>

## W9
### Activity 1
Game: Hollow Knight Silksong<br>
(all gifs are from the Hollow Knight Silksong Wiki)<br>
System 1: Flea Brew Color Pulse<br>
<img src="https://cdn.wikimg.net/en/hkwiki/images/3/39/GIF_SS_Flea_Brew_01.gif"><br>
When Hornet drinks flea brew, her sprite pulsates with a golden colour for the duration of the brew's effect.

I think this is an effect on the player (Hornet)'s material, it would be helpful to have such a pulsing effect that you could customize with different colors, durations, etc. for different player statuses or animations. Major features would most likely be tinting the sprite by multiplying the player sprite (texture) with a given colour, and changing how much the sprite is tinted with the color over time. I think it would be easiest to set this by changing the material settings, especially if there are multiple kinds of color flashes being used in the game, you could just set the color, duration, and any other settings.

System 2: Plasmium Overdose Screen Flash <br>
<img src="https://cdn.wikimg.net/en/hkwiki/images/thumb/0/06/GIF_SS_Plasmium_Phial_02.gif/400px-GIF_SS_Plasmium_Phial_02.gif"><br>
When Hornet overdoses on plasmium, the screen flashes with a cyan light during the animation.

I think this is a postprocessing effect, since the effect appears to affect the entire screen. Every pixel on the screen is multiplied with the cyan colour. After a while, the cyan fades away. I think this would best be triggered by enabling/disabling the postprocessing effect, since... well, I believe it's a postprocessing effect, and this effect is only shown occasionally in gameplay on trigger, rather than being active all the time.

### Activity 2
<img width="1578" height="826" alt="2026-05-27 18-56-36" src="https://github.com/user-attachments/assets/1924da6a-5988-413c-9bf6-34ad2c0023e7" />
I started and finished a shader I intend to use on the items in my game. When the user's sticky hand is close enough to pick up an item, it will flash using this shader. I had one issue with getting it to start and stop, and the problem turned out to be that sprites use a transparent texture, so instead of drawing AfterOpaque (as we did in previous class activities) it should have been drawn AfterTransparent.

I was originally intending on making an outline shader similar to the one we did for the shiba in last week's activity A, but soon realized that since I'm working with 2D sprites rather than 3D meshes, the process is very different and much more involved, so I settled for this instead.

<hr>

## W10
### Activity 1
[Itch Link](https://sunrd.itch.io/adventure-of-a-sticky-hand-playtest-3)<br>
New content: smoother movement, gun fixes (should no longer fire bullets backwards when at specific angles), removed item smuggling (bringing an item from the previous level to the next)

Playtesting goals: I want feedback as to whether or not players know what to do when they start playing my game, since that's basically what the graders will be trying to figure out for the final submission... :)

Feedback: 
Can put more instructions. It is not clear what checkpoints and level goals look like, it can be difficult to identify items that can be picked up, and how to use items in different ways.

The direction of the firing of the gun is unintuitive, and should probably fire in the direction the arrow suggests.

### Activity 2
When planning a game:
1. Identify major systems<br>
   eg: Character, DialogueSystem, QuestManager
2. Identify what those systems do
    - Why is this system needed?
    - What does this system accomplish?
    - What does this system need to accomplish its task?
3. Identify how those systems interact with each other<br>
    eg: talking to Character through DialogueSystem gives a Quest, which is tracked by QuestManager...
    - Any functions
    - Data required
4. Slim down
    - Reduce repetition of code: try to identify shared data/behaviors that could be slimmed down using super/subclassing, interfaces, etc
5. Break steps down
    - Some interactions can be complex or lengthy, so breaking them down into manageable steps makes the process more achievable (visible progress)
6. Write this information somewhere
    - Pick a readable, intuitive way to store the info (eg: an object and interaction map)
    - Actually refer to this information during development

In creating the plan for a game, for me, it helps me point out and cut feature bloat, and identify tasks that might take longer or shorter periods of time. A lot of the time I realize I'm overscoping, and need to cut it down to something more basic before I try to implement more.

### Activity 3
Five levels is a bit short so I'm working on another one. Not sure how much I'm aiming for in the final submission, maybe eight?
I'm also adding more crusher types, you can't have enough hazards in a platforming game. I kind of want to add an OMORI-style dilemma in a level where you find out you didn't actually have to kill the enemy to proceed in the level. (Oops. spoilers.)
