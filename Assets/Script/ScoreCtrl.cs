using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCtrl : MonoBehaviour
{
    public int score;
    public Text scoreText;
    private Transform mygame;
    // Start is called before the first frame update
    void Start()
    {
        mygame = GameObject.Find("Ctrl").transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddScore(int value)
    {
        score += value;
        scoreText.text = "得分+" + value + "=" + score;
        //Debug.Log("当前得分：" + score);
        // End.transform.SendMessage("PrintScore", score);
        mygame.SendMessage("GetScore", score);
    }
}
