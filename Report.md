Lab Task 1

Features Implemented:

1. FPS Camera:
   FPSCam script was used to control the Camera. Mouse axis X was used to rotate the transform of the player object. Vertical rotation was clamped to prevent weird camera angles.

2. Player Movement:
   Unity's new input system was used to implement player movement. The Player movement script also contains a Shoot method using raycast and gravity to keep the player on the ground.

3. Sphere Colors:
   A script was used to generate a new random colour by generating random values for the rgb attributs of Color. The RandomizeColour method is called every 3 seconds.

4. Cube Shooting:
   A target script was made for the cubes. It tracks how many times it was 'Hit' and destroys the gameobject it is attached to at 10 hits.

5. Room:
   As per the requirements, an enclosed room was created with pillars inside it. All components of the room has textures which includes albedo, roughness map, hight map, ambient occlusion and normal map. Textures were sourced from: https://www.textures.com/free
