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
}
