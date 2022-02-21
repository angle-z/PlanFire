using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBullet : MonoBehaviour
{
    public float speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        this.name = "Bullet";
    }

    // Update is called once per frame
    void Update()
    {
        float dy = speed * Time.deltaTime;
        transform.Translate(0, dy, 0, Space.Self);
        Vector3 sp = Camera.main.WorldToScreenPoint(transform.position);
        if(sp.y>Screen.height)
        {
            Destroy(this.gameObject);
        }

        

    }
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if(collision.tag.Equals("Monster"))
    //    {
    //       // Destroy(collision.gameObject);
    //        Destroy(this.gameObject);
    //        GameObject Monster = GameObject.Find("主控脚本");
    //      //  Monster.SendMessage("AddScore", 1);

    //    }
    //}
}
