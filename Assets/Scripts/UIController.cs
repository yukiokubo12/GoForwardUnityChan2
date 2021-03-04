using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    private GameObject runLengthText;
    private GameObject gameOverText;
    private float len = 0;
    private  float speed = 5f;
    private bool isGameOver = false;

    void Start()
    {
        this.runLengthText = GameObject.Find("RunLength");
        this.gameOverText = GameObject.Find("GameOver");
    }

    void Update()
    {
        if(this.isGameOver == false)
        {
            this.len += this.speed * Time.deltaTime;
            this.runLengthText.GetComponent<Text>().text = "Distance: " + len.ToString("F2") + "m";
        }
        if(this.isGameOver == true)
        {
            if(Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
    }
    
    public void GameOver()
    {
        this.gameOverText.GetComponent<Text>().text = "GAME OVER";
        this.isGameOver = true;
    }
}
