﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoScriptAP : MonoBehaviour
{
    public UnityEngine.Video.VideoClip videoClip;
        public AudioSource MusicSource;


    // Start is called before the first frame update
    void Start()
    {
        var videoPlayer = gameObject.AddComponent<UnityEngine.Video.VideoPlayer>();
        var audioSource = gameObject.AddComponent<AudioSource>();
        videoPlayer.playOnAwake = false;
        videoPlayer.clip = videoClip;

    }

    public void PlayVideo()
    {
        var vp = GetComponent<UnityEngine.Video.VideoPlayer>();
        vp.Play();
    }

    public void PauseVideo()
    {
        var vp = GetComponent<UnityEngine.Video.VideoPlayer>();
        vp.Pause();
    }

    public void StopVideo()
    {
        var vp = GetComponent<UnityEngine.Video.VideoPlayer>();
        vp.Stop();
    }

}
