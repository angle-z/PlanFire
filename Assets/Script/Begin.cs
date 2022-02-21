using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Begin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Btn_Begin()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        Debug.Log("开始按键按下");
    }
}
