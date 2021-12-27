using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class urlVidLoader : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public string videoUrl = "https://unity-youtube-dl-server.herokuapp.com/";

    void Start()
    {
        videoPlayer.url = videoUrl;
        videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
        videoPlayer.EnableAudioTrack(1, true);
        videoPlayer.Prepare();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
