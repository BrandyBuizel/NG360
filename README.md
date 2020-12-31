# README

### Credits
Code & Setup: 
BrandyBuizel ([@BrandyBuizel](https://twitter.com/BrandyBuizel))

Some camera code provided by like 7 different sources on the internet.
I went through about a dozen different methods(mp4, cubemaps, flipped normal cubes, flipped half spheres, png sequences, etc.) before settling on streaming source video from ungrounded.net via the same project file on the website.

### How to Make Your Own 360 Video
- Make a 360 video animation, I'm not gonna explain this one, just look somewhere else online
- Upload the video file(that warped sphereically unwrapped mess) to Newgrounds in a Movie Project File
- Publish the project(just for a moment, you can unpublish it after this step), inspect the video player element and find the source URL hidden in the video tags to "uploads.ungrounded.net" (e.g. https://uploads.ungrounded.net/alternate/1276000/1276946_alternate_118467.720p.mp4?1609176153)
- Open the Unity Project(let it build the libraries, might take a while), click on the sphere object in the only scene, replace the URL with your own video link
- Build for WebGL and upload the .zip file to your Newgrounds Movie Project and make the HTML5 archive as the priority player format!
- DO NOT DELETE the movie file, anytime you update your movie file it will generate a new link to "uploads.ungrounded.net" so you'll need to update the .zip of your game too
