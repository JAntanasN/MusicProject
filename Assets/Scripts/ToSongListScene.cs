using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToSongListScene : MonoBehaviour
{
    public void SceneStart()
    {
        SceneManager.LoadScene("SongsList");
    }
}
