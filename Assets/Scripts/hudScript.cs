using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.Video;

public class hudScript : MonoBehaviour{
    public GameObject videoSource;
    public GameObject hudButton;
    public bool isPlaying;
    //public bool canLoop = false;

    //public long playerCurrentFrame;
    //public long playerFrameCount;
    
    void Start(){
        videoSource = GameObject.FindWithTag("Video");
        videoSource.GetComponent<VideoPlayer>().Prepare();
        //videoSource.GetComponent<VideoPlayer>().StepForward();

        //Change Camera to set start screen to black
        this.GetComponent<Camera>().farClipPlane = 1;
    }

    void Update(){
        //playerCurrentFrame = videoSource.GetComponent<VideoPlayer>().frame;

        if(!isPlaying){
            //Mouse Click to Play and Give Permission to Stream Audio
            if (Input.GetMouseButtonDown(0)){
                videoSource.GetComponent<VideoPlayer>().Play();
                isPlaying = true;
            }

            //Play on Space
            if (Input.GetKeyDown("space")){
                videoSource.GetComponent<VideoPlayer>().Play();
                isPlaying = true;
            }

            hudButton.SetActive(true);
        }else if(isPlaying){
            //Pause on Space
            if (Input.GetKeyDown("space")){
                videoSource.GetComponent<VideoPlayer>().Pause();
                isPlaying = false;
            }

            hudButton.SetActive(false);
            this.GetComponent<Camera>().farClipPlane = 1000;
            //playerFrameCount = System.Convert.ToInt64(videoSource.GetComponent<VideoPlayer>().frameCount) - 10;
        }

        /*
        if(playerCurrentFrame < playerFrameCount){
            Debug.Log("...");
        }else{
            Debug.Log("end of video");
            isPlaying = false;
            videoSource.GetComponent<VideoPlayer>().Stop();
        }
        */

        /*
        if(videoSource.GetComponent<VideoPlayer>().time == 0 && isPlaying && canLoop){
            videoSource.GetComponent<VideoPlayer>().Pause();
            isPlaying = false;

            Debug.Log("end of video");
        }

        if(videoSource.GetComponent<VideoPlayer>().time > 1){
            canLoop = true;
        }
        */
    }
}