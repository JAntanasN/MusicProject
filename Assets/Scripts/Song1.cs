using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Song1 : MonoBehaviour
{
    public void SceneStart()
    {
        SceneManager.LoadScene("MusicPlayerScene");
    }
}
