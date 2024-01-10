using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int gameLevel;

    public void Start()
    {
        DontDestroyOnLoad(this);
    }

    public void Update()
    {
        if (SceneManager.GetActiveScene().name == "GamePlay_Level1")
        {
            gameLevel = 1;
        }
        else if (SceneManager.GetActiveScene().name == "GamePlay_Level2")
        {
            gameLevel = 2;
        }
    }
}
