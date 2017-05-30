VR Nanodegree Course - Project 5 (Night at The Museum)
-------------------------------------------------------------------------------

This is the Udacity VR Developer Nanodegree Project number 5. 

I wanted to create an informative and interesting museum experience about space exploration in VR, where you can learn about the topic, see spacecraft 3D models, and immerse yourself in a VR experience with the International Space Station internal environment as well as astronauts training.  

As I've visited recently London Science and National History museums, I just wanted to make an experience close to being in such large structures. I've tested myself a new VR experience in London Science museum, so I based the project on how VR could be used in teaching content and giving thrilling experiences in museuem.

Some links for reserach:
    https://www.fi.edu/vr-at-the-museum
    https://www.fi.edu/virtual-reality
    https://www.fi.edu/exhibitions 
    http://www.sciencemuseum.org.uk/visitmuseum/plan_your_visit/simulators/space_descent_vr ... That's the one I experienced in Londong science museum'

+ other research done on the different spacecrafts used in the project + audio documentray or informative content that I used from youtube.

One can spend about 15+ mins in this experience listening to informative content and checking posters as well as the 3D models.

Making the 360 video was the troublesome part as the MovieTexture class is not supported on mobile platforms. I've tried Unity5.6 to utilize its new video player component, however I ran into several bugs as in here https://discussions.udacity.com/t/right-eye-renders-at-a-different-quality-than-left-eye/245515/19 .. So I've rebuilt the whole scene back in unity5.5.1f1 and used this link http://fusedvr.com/building-a-360-video-player-from-scratch/ to make the 360 video, but without flipping normals on Blender as it didn't work with me - it reversed text as well ! - So I used a custom shader from this link https://medium.com/@verochan/how-to-make-a-360%C2%BA-image-viewer-with-unity3d-b1aa9f99cabb .. The fading function was in one of unity tutorials that I went through before. This one https://unity3d.com/learn/tutorials/projects/adventure-game-tutorial, however, I didn't use the vignette image effect as I've used a simpler idea of having a canvas in front of the camera that I sue its alpha for fading out and in.

It worked for Android but IOS doesn't support this 360 video implementation.

I've built the whole museum, and the logic. Used standard 3D models from the free asset library for the spacecrafts, gravity generator, door, light, and fan, and of course the Oculus rift on the ISS stand. The waypoint movement script was provided by the course using the iTween free library asset. 

The scene is baked at only 10 resolution, and it looks fine .. It could have been baked at a higher quality, but it takes really a long time on Unity to bake lights.

A link to the youtube video of the museum: https://www.youtube.com/edit?video_id=YsVrx1U_PGQ

Google VR SDK version: From this link https://github.com/googlevr/gvr-unity-sdk/releases/tag/v1.0.3  (The one provided with the starter project 3 from Udacity)
Unity 5.5.1f1

