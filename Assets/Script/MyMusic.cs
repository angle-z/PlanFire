using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MyMusic : MonoBehaviour,IPointerDownHandler
{
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetMouseButtonDown(0))
        //{
            
        //        AudioSource audio = GetComponent<AudioSource>();//获取音乐组件
        //        if (audio.isPlaying)
        //        {

        //            audio.Pause();
        //        }
        //        else
        //        {

        //            audio.Play();
        //        }
            
        //}
        
    }
    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {

        AudioSource audio = GetComponent<AudioSource>();//获取音乐组件
        if (audio.isPlaying)
        {

            audio.Pause();
        }
        else
        {

            audio.Play();
        }
    }

}
