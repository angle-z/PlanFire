using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyJet : MonoBehaviour
{
    public float speed ;
    public GameObject bulletPrefab;

    private float count = 0;
    private float interval = 0.4f;
    public float deltaT = 0.5f;
    private float InvokeTime;
    // Start is called before the first frame update
    void Start()
    {
        InvokeTime = deltaT;
    }

    // Update is called once per frame
    void Update()
    {
        //count += Time.deltaTime;
        //if(count >interval )
        //{
        //    count = 0;
        //    Fire();
        //}
        float step = speed * Time.deltaTime;
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-step, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(step, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, step, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -step, 0);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            InvokeTime += Time.deltaTime;
            if(InvokeTime>deltaT)
            {
                Fire();
                InvokeTime = 0;
            }

        }
        if(Input.GetKeyUp(KeyCode.Space))
        {
            InvokeTime = deltaT;
        }

    }
    void Fire()
    {
        Vector3 pos = transform.position + new Vector3(0, 1, 0);
        GameObject bullet = Instantiate(bulletPrefab, pos, transform.rotation);
        //
        AudioSource audio = GetComponent<AudioSource>();//获取音乐组件
        audio.PlayOneShot(audio.clip);
       
    }
}
