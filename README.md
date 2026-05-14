<img width="841" height="718" alt="Screenshot 2026-04-15 at 11 30 12 PM" src="https://github.com/user-attachments/assets/6cec670e-adc3-4cf5-b6c1-642bb91ee743" />
# GDIM 33 In-Class Activities
## W1
### Activity 1
[Inspo board link](https://miro.com/app/board/uXjVGoFaoKg=/)

1.  I was very interested in themes like eggs, romance, and human communication, which I’m always drawn to, along with socializing gameplay mechanics beyond just dialogue. From the life sim genre, I noticed I wrote a lot down from it. It became a mix of: point-and-click, life sim, strategy, story-rich, dark comedy. Game mechanics, I thought of systems like building a picture of someone or traveling through their life through the questions you ask.

2.  I was talking with Isabel, who also wanted to do a similar Papers, Please-inspired game. They think a lot more about games they already like and the struggle of coming up with a new idea, whereas I think of a lot of ideas I like and focus more on the artistic side. I’m more lacking in the concrete gameplay I’m drawing from.

3.  Our table’s LA has a really interesting taste in games. She talked about how she likes games like Omori and prefers ones that are not as movement-based, which I also agree with. We bonded over roguelikes and discussed how to improve upon those mechanics.



### Activity 2
<img width="960" height="720" alt="image" src="https://github.com/user-attachments/assets/48d3a2e8-547b-47e3-b1e9-501ff5764172" />


## W3
### Activity 1
<img width="841" height="718" alt="Screenshot 2026-04-15 at 11 30 12 PM" src="https://github.com/user-attachments/assets/7aecb9cb-624e-43ad-b197-7984ef6133e1" />


### Activity 2
1.  It is advantageous to save the event name for the explore-to-dialogue state transitions as a Scene variable ("clickNpcEventName") because it becomes a sort of global variable and can be used across different graphs and be recognized. 
2. I used two instances of debug.log() node with different descriptions printed, to check if the program was switching between both states of dialogue and exploration mode, with different debug text to see if it was transitioning or not. This helped me narrow down where the problem was.
3. Yes, for my future project (a social skill simulator), the Set Cursor Lock State is actually relevant since there shouldn’t be any clicking during exploration. It was surprisingly simple.
4. Yes, the concept of "a game state" is very relevant. Since I am switching scenes often and with a fail condition, this was really helpful.

## W4
### Activity 1
 Currently, in my build with visual scripting, there is a movement system, the ability to click to switch states, UI, a main character model, a scene, and NPC models. The playtesting goals were to see how intuitive the UI was and how the movement felt, navigating the scene, interacting with the UI, and clicking.

##  My playtesting notes:
 My playtest members were Jacob, Isabel, Kristin, and Andy.

-  «Who’s Laila?» recommended for playing
- Textures need to be added
- UI is good and clear, although people are curious about the upper left icon
- character is floating, not goal
- character can ride on NPCs shoulder, she is not falling as she should
- Camera is working well, all be it the controls are following the camera and not the character
- people like the models
- Clear expressions in the UI, and the UI state machine is working and changing
- Feels evil


### Activity 2
1. I believe a writer could add more dialogue to this setup without writing any code. Using scriptable objects, they could edit and replace them with real dialogue for the whole flow and setup. From experience, I know having a programmer on board for polish helps, but realistically, I think an arrangement could be made where a writer could add to it without any code.
2.  In terms of dialogue nodes, without writing any code, it seems unlimited to the number you could make without writing anycode. One thing is creating them, another is hooking them up. For this activity alone, I could write as many as I wanted before having to deal with code. I assume the limit is how many could be connected, and whether the writer was in charge of that.
3. The "Regenerate Nodes" button seems to add custom nodes to the default Unity search options you get to choose from in visual scripting.

## W5
### Activity 1

Animation 3d steps
information still needed:
* Parameters outlined
* Define states

This system will play a different animation depending on which dialogue choice is chosen, using a state machine and enums.

BIG STEPS
1. Code a separate state machine from the one I already have and build the state machine, test transitions between states using debug logs only
2. Download and add animations to Unity
3. Use the state machine to change animations
4. Trigger animation changes connected with Scriptable Objects

SMALLER BIT-SIZED STEPS
1. Add enums to the NPC for storing state
2. Use debug logs to verify if an animation would be triggered after certain dialogue choices
3. State machine sends a transition signal to the animation controller
4. Fire off animation changes via Scriptable Objects
5. Create animations in Blender and transfer them
6. Add an Animator to the player
7.  Test each animation individually by setting it as the default animation state and running the game
8. Add parameters to the Animator to control states
9.  Update the state machine so the Idle animation plays when the game starts
10. Continue building and testing one animation state transition at a time until all transitions are validated


### Activity 2
Today I created an animation for my NPC in Blender, built a rig in Unity using 52 bones, set up animation parameters, and attached everything to the NPC.
Next step is to get my state machine fully working.

## W6
### Activity 1
my playtesting goal is to check the current dialogue and scene flow, if animations are working, checking for bugs, and seeing if changes made to UI, art, and scene and dialogue, as they haven’t played that yet, works, mostly looking for dialogue scene feedback. since my milestone 1 i got animations working and a new scene with a new character i made and dialogue,

##### playtesting notes
Scene progression is working, control sensitivity is very sensitive. Everything is intuitive but clicking when it comes to controls, movement is funny, make the typing faster for dialogue, add skybox, dialogue mode wrong connection goes back to previous scene, animation working, oh there is a skip option for some button seems to be broken, new one added today. Need to set up my colliders for scenes. The dialogue choices are working, people are reading out loud, first one is hard to click on, eerie vibe talking to zoya character. People love the UI 

### Activity 2
1. multiply setting of the blend node makes the resulting color darker, because it’s multiplying fractions and becoming a lower numbers, and lower numbers are darker and less saturated than the inputted color.
2. if we use multiply to combine alpha values i would assume it works similar with multiplication of fractions being less translucent than either of the values because it would be a lower number.
3. the shader gets the UV values from the mesh data which stores the UV coordinates.
4. it sounds both interesting and exciting to manipulate colors with math, for a general color match in a scene, and for making ghosts.

## W7
### Activity 1
1. I think the data for the vertex color shader comes from the mesh’s surface normals as (r, g, b) color.
2. I would assume the vertices at the edges appear more blended cause of the vertex data becomes more distorted along the edges.
3. I believe the vertex colors are generated by computer data,  which is less detailed compared to the model from last week, as its rendered texture applies itself to the meticulously planned texture. 
4. Given that vertex color generally results in a less detailed color application than applying a texture, what can you imagine vertex color is useful for? I think great if you don't have time to texture all objects in a scene. 
6. Based on the color of the shiba in step (4), the mesh’s vertex normals have different color sections with patches of uneven color. 
7. One other piece of data I can imagine testing with a debug shader like this is to see if the texsturing is stretched, or wrapped properly on the model, looking for uneven color.
8. I'm assuming the error in the back of the Shiba is uneven mesh with the texture not properly aligned. 
9. I think using the blend mode additive keeps the patterns on the fire effect while still blending  the texture in with the color.


