using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler1 : MonoBehaviour
{

    public float maxSize = 1.5f;
    public float minSize = 0.3f;

    
    
    private void Start()
    {
        AudioDetector.inst.onBeat.AddListener(Scale);
    }

    public void Scale(float t)
    {
        var scale = Mathf.Lerp(minSize, maxSize, t);
        transform.localScale = Vector3.one * scale;
    }
}
