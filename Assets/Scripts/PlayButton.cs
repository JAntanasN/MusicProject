using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class PlayButton : MonoBehaviour
{
    public Sprite pauseSprite;
    public Sprite playingSprite;

    Button button;
    bool isPaused = false;

    
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnPause); // attach function
    }

    
    void Update()
    {
        
    }


    void OnPause()
    {
        isPaused = !isPaused;
        AudioDetector.inst.Pause(isPaused);

        button.image.sprite = isPaused ?
            playingSprite : pauseSprite;
    }
}
