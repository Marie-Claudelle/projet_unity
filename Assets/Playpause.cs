using UnityEngine;
using UnityEngine.Video;



public class Playpause : MonoBehaviour

{

    

    private VideoPlayer video;



    private void Awake()

    {

        video = GetComponent<VideoPlayer>();

    }
    public void PlayVideo()
    {
        video.Play();
    }

    public void PauseVideo()
    {
        video.Pause();
    }




}
