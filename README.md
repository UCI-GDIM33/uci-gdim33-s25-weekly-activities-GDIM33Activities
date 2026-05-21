# GDIM 33 In-Class Activities
## W1
### Activity 1
<img width="874" height="654" alt="Screenshot 2026-04-01 185512" src="https://github.com/user-attachments/assets/9393946c-9b44-4646-bee8-0783d4e44068" />

1. There was a definite pattern where most of the inspiration I would reference came from horror media, specifically psychological horror narratives like The Shining, No I'm Not a Human, 
and Silent Hill 2. These are all pieces of media that focus heavily on the dynamic interactions between charcaters, and how they may change over time. In terms of atmosphere, I focused in large
part in contemporary environments that would be easily relatable to the audience.
2. Discussed with Jasmine on the interest in horror media, and the importance of narrative in gaming. The games we plan to build, however, are extremely different in terms of genre and style. 
3. Discussed with Michael on his interest in fighting games, and how to intigrate the complex mechanical intensity of these games into other game archetypes, such as narrative games or RPGs.

### Activity 2
<img width="878" height="661" alt="Screenshot 2026-04-01 194356" src="https://github.com/user-attachments/assets/80bec3f2-ac83-49b9-a998-0467f6829789" />

## W2
Write your W2 Devlog here.

Continue adding additional headers below this one for future weeks and future activities.

## W3
### Activity 1
Updated break-down:
<img width="878" height="657" alt="image" src="https://github.com/user-attachments/assets/ec1351a9-455c-448b-a218-0516da796c0f" />

### Activity 2
1. It's advantagous to use Scene Variable for the explore-to-dialogue state transitions as it allows the program to manipulate the UI within the scene itself.
2. The Debug.Log() nodes helped in diagnosing the issue with the endDialogue event by writing in the console that the walrus registers the cursor click, meaning the issue was with the state transition instead of the click event trigger.
3. Set Cursor Lock State is not very relevant to my Vertical Slice being that the player is intended to be stationary thorughout the experience, similar to Papers, Please.
4. Game State is likely relevant to my Vertical Slice in order to trigger events based on whether one of the neighbors is at the door, allowing the player to access items in the time in between, or trigger the day to end.

## W4
### Activity 1
#### Part I
Currently, in the playtest build there is a working dialogue system. This was the main element I wanted to focus on before playtesting, at it is probably the most crucial mechanic to introduce in the game, and likely the most versitile.

As for playtesting goals, I would aim for playtesters to test whether the branching dialogue system not only works without bugs, but is fluid and immersive, even within itws limited state.

#### Part II
Giovanni Solorio
Joshua Paxton
Jasmine Caicedo

#### Part III
Feedback insinuated that the dialogue system worked well enough to be attached to multiple NPC, which was essentially the intended purpose behind the playtest. That said, it was recommended that I add some kind of animation to present the player speaking, especially given the lack of movement in the game itself.

### Activity 2
1. Since the NewDialogueEvent graph will simply instaitiate more reply buttons as long as responses are written under the Dialogue Node, a writer can add infinitely more diallogue and branches to the conversation without ever writing a piece of code. Thry need to simply create another Dialogue Node to continue writing lines and replies.
2. As said previosuly, there is no limit to the number of Dialogue Nodes that the writer can create, as the NewDialogueEvent graph simply checks whether the current node has an attached reply. So long as it does, a new button would be instantiated to signal a new reply.
3. Regenerate Nodes is required to reconfigure all available Visual Scripting nodes to be compatible with each other whenever a new package or node is added.

## W5
### Activity 1
Creation of the Infection System:
- Make the infection_state enum correspond to the total "favor" the player has accumulated:
    - Introduce inheritence to the NPC class.
    - Create an abstract class within the parent class to be manipulated by the children.
    - Use a switch statement to set the conditions of change for infection_state depending on how much favor the player garners.
- Change NPC appearence according to infection_state:
    - Implement new art assets onto Unity
    - Create a [SerializeField] to add these assets within the parent NPC class.
    - Change the presented sprite within the afformentioned switch statement.

### Activity 2
Added a state machine system and created an inherited class from NPC called "CollegeKid" where a switch statement would determine the condition of each NPC depending on the total "favor" the player accumulates. 

## W6
### Activity 1
#### Part I
I've barely had time to work on this project, as I am currently involved with two other projects, but between the last milestone and now, I fixed multiple bugs regarding the visual scripting

(https://gio-solorio.itch.io/new-thing)

Playtesting goals:
- Viable replayability using the "favor" stat manipulation.
- Engagement with an immersive, or otherwise engaging, narrative concept.

#### Part II
Playtesters: Jasmine Caicedo, Joshua Paxton

Notes: Playtesters believed the experience became much more lively with live voice-acting. The possibility to give each character proper voice work could aid in immersing the player within the environment.

### Activity 2
1. Both the multiplied values within the channel will be decimals between 0.0 - 1.0, hence they will equal a smaller value than the input. In RGB channels, values closer to 0.0 are represented as being darker, with 0.0 itself representing black.
2. Similar to the previous example, values closer to 0 will ultimately be more transparent. Being that the values being multiplied will typically be between 0.0 - 1.0, it means the result will be more transparent.
3. The texture sampling node gets the UV coordinates from the Shiba's UV Map, allowing any texture to be applied.
4. I'm not personally an artist, so I tend to stay away from having to manage the art creation between more projects unless absolutely necessary. With that being said, I have multiple friends who are artists and would likely be much more eager to take advantage of this tool.

## W7
1. The data for data for the VerterxColor graph comes from the UV map within the mesh, which allows the shader graph to know how to apply the texture onto the Shiba model.
2. All Vertexes within the model have an assigned color. Between each point, these vertex color are calculated to blend together.
3. Vertex color is generally less detailed than rendered textures being that the vertex color is contrained by the geometry of the model with general estimates between 
set colors at each vertex. Vertex color may be a better use for general estimates of how a model will look before applying an actual render.
4. There's a patch where the Shiba's surface normal within the model is not alligned with the rest.
5. Along with visualizing the vertex normals of a mesh, the shading debugger can also be used to essentially visualize the dynamics how proper lighting will interact 
in relation to the mesh.
6. The lighting error is caused being that the vactor coming from the Shiba and from the light source are coming from different ways, one being negative and the other 
being positive. This causes the dot product to become negative, causing an inverted lighting scheme. In order to fix it, the vector coming from the Shiba must be 
multiplied by a negative so that the resulting dot product may be positive.
7. Making the Blend Mode additive adds the background's color to the shader, making it seem more natural.

## W8
### Activity 1
1. Made failsafes as to ensure that "favor" isn't accumulated twice over within a node.
https://gio-solorio.itch.io/playtest
Playtest Goals:
Represent diverse narrative branches through player choices within gameplay. These choices outline the interactions between energy, through investigations and the energy drink item, as well as accumulated "favor," through choosing certain dialogue options.

2. Playtest Notes:
- The animations are janky, and the vidual scripting graphs associated with them need to be cleaned up
- The game needs proper art.

### Activity 2
1. The fraction node takes floats and uses the value only after the decimal to make further calcutlations. Being that time is typically measured as a float in Unity, counting milliseconds into each second from the scale of 0.0 - 0.9, it can be applied to ensure that every second the sprite material will illuminate and revert back to its original state every second. This is what produces the shining effect.
2. If the Sprite texture were set to white, like it is by default, the sprite would consistently be illuminated. The texture, therefore, needs to be set to black as the default in order to allow the illumination to accumulate over time, and later revert once more. Being that it is an effect atop the original texture, however, it needs to be added to make the effect work properly.
3. It's likely that the reason why the texture of the sprite doesn't change, even when the default changes, is because the sprite's texture overwrites the default. Hence, the effect triggers over the sprite's texture instead of the default texture.
4. As previously stated, the time node is needed to ensure the shine effect is repeated continuously every second. Multiplying it by ShineSpeed, however, can increase the amount of times the effect repeats per second.