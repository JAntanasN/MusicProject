using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    private AudioDetector audiodetector;


    public void ButtonPressed()
    {
        audiodetector = FindObjectOfType<AudioDetector>();

        AudioSource music = audiodetector.audiosource;

        if(music.isPlaying) 
        {   
            music.Pause();
            
        }
        else
        {
            music.Play();
           
        }
 
    }


}
