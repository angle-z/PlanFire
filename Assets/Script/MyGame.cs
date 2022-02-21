using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyGame : MonoBehaviour
{
    public int score ;
    //public Text scoreText;
  
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
       
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void GetScore(int Score)
    {
        score = Score;
    }
    //public void AddScore(int value)
    //{
    //    score += value;
    //    scoreText.text = "得分+"+value+"="+ score;
    //    //Debug.Log("当前得分：" + score);
    //   // End.transform.SendMessage("PrintScore", score);
    //}
}
