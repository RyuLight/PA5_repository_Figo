using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public Rigidbody playerRigidbody;

    public TextMeshPro CoinText;
    private int coinCount;

    private void Start()
    {
        coinCount = 0;
        CoinText = GameObject.Find("CoinText").GetComponent<TextMeshPro>();
    }

    private void FixedUpdate()
    {
        CoinText.text = "Coins Collected: " + coinCount;
        float MoveHorizontal = Input.GetAxis("Horizontal");
        float MoveVertical = Input.GetAxis("Vertical");
        playerRigidbody.MovePosition(transform.position + new Vector3(MoveHorizontal * (speed * Time.deltaTime), 0 , MoveVertical * (speed * Time.deltaTime)));
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            coinCount++;
        }
        if (collision.gameObject.CompareTag("Hazard"))
        {
            SceneManager.LoadScene("GameLose");
        }
    }
}
