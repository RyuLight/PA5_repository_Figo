﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UIUpdate : MonoBehaviour
{
    public int totalCoin;

    private void Update()
    {
        totalCoin = GameObject.FindGameObjectsWithTag("Coin").Length;
        if (totalCoin <= 0)
        {
            //SceneManager.LoadScene("GamePlay_Level2");
            SceneManager.LoadScene("GameWinScene");
        }
    }
}
