using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class AudioDetector : MonoBehaviour
{
    public static AudioDetector inst;

    public int samplerate = 1000;

    float[] samples;
    float average;

    public UnityEvent<float> onBeat;

    public UnityEvent<float, float> onPlay;

    public UnityEvent<float, float> onButtonPress;

    public AudioSource audiosource;

    private void Awake()
    {
        if(inst == null)
        {
            inst = this;
        }
        else
        {
            Destroy(gameObject);
            Debug.Log("Sound analyzer duplicates");
        }
    }
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        samples = new float[samplerate];
    }



    void Update()
    {
        if(audiosource.isPlaying) 
        {
            audiosource.clip.GetData(samples, audiosource.timeSamples);

            average = 0;

            foreach (var sample in samples)
            {
                average += Mathf.Abs(sample);
            }
            average /= samplerate;

            onBeat.Invoke(average);
            onPlay.Invoke(audiosource.time, audiosource.clip.length);
        }
    }


    public void Adjust(float value)
    {
        audiosource.time = value * audiosource.clip.length;
    }

    public void Pause(bool pause)
    {
        if (pause)
        {
            audiosource.Pause();
        }
        else
        {
            audiosource.Play();
        }
    }
}
