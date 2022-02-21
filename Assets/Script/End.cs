using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class End : MonoBehaviour
{
    Transform WenZi;
    Transform Flag;
    
   // public string url= "http://h4ck.fun/playg4mehavefun.txt";
   // public string url2 = "http://h4ck.fun/test.txt"; 
   // public string url3 = "http://h4ck.fun/have_fun_nctf_2021.txt";
    public string url4 = "http://h4ck.fun/g4me.txt";
    //Text WenZi;
    // Start is called before the first frame update
    [Obsolete]
    void Start()
    {
        WenZi = GameObject.Find("Text_Score").transform;
        Flag = GameObject.Find("Text_Flag").transform;
        // Text text = WenZi.GetComponent<Text>();

        PrintScore();
        Debug.Log("应该会显示分值啦");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Btn_Agian()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        Debug.Log("重新开始按键按下");
    }

    [Obsolete]
    public void PrintScore()
    {
        int score = GameObject.Find("Ctrl").GetComponent<MyGame>().score;//获取其它场景内数据
                                                                         //GameObject.Find("脚本所在物体名").GetComponent<脚本名>().函数名()
        
        string str2 = "很遗憾！您的分数未达到300分，未成功！";


        WenZi.GetComponent<Text>().text = score+"分";
        if (score > 299)
        {
            StartCoroutine(getRequest(url4));
           
        }
        else
        {
            Flag.GetComponent<Text>().text = str2;
        }
    }

    [Obsolete]
    public IEnumerator getRequest(string uri)
    {
        UnityWebRequest uwr = UnityWebRequest.Get(uri);
        yield return uwr.SendWebRequest();

        Flag.GetComponent<Text>().text = uwr.downloadHandler.text;
        Debug.Log(""+ uwr.downloadHandler.text);
    }


}
