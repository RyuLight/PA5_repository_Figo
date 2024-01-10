using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public GameManager GM;

    private void Start()
    {
        GM = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    public void Restart()
    {
        if (SceneManager.GetActiveScene().name == "GameLose")
        {
            switch (GM.gameLevel)
            {
                case 1:
                    SceneManager.LoadScene("GamePlay_Level1");
                    break;

                case 2:
                    SceneManager.LoadScene("GamePlay_Level2");
                    break;
            }
        }
        else if (SceneManager.GetActiveScene().name == "GameWinScene")
        {
            SceneManager.LoadScene("GamePlay_Level1");
        }
    }
}
