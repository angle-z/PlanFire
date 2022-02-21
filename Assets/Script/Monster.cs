using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Monster : MonoBehaviour
{
    public float speed = 1.0f;

    public int value; // 价值 (1-5), 击杀此怪可以获得的加分

    public int hp; // 血量, 初始值为value

    // hp/value节点
    private Transform hpNode;

    private Transform game;

    // Start is called before the first frame update
    void Start()
    {
        // 节点名称
        this.name = "Monster";

        game = GameObject.Find("主控脚本").transform;

        // 怪物的价值：1-5之间，随机指定
        value = Random.Range(0, 5) + 1;
        hp = value;

        // 血条显示
        hpNode = transform.Find("hp/value");
        SetHealth(hp);
        //
        
    }

    // Update is called once per frame
    void Update()
    {
       

        float dy = speed * Time.deltaTime;
        

        transform.Translate(0, -dy, 0, Space.Self);

        Vector3 sp = Camera.main.WorldToScreenPoint(transform.position);
        if (sp.y< 0)
        {
            Destroy(this.gameObject);
            UnityEngine.SceneManagement.SceneManager.LoadScene(2);
           
            //Application.Quit();
            Debug.Log("游戏结束");

        }
       
    }
    // 更新HP显示
    public void SetHealth(int hpValue)
    {
        hpNode.localScale = new Vector3(hpValue / 5f, 1, 1);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.Equals("Bullet"))
        {
            // 被子弹击中，HP-1
            hp -= 1;
            Destroy(collision.gameObject);
            // 更新HP显示
            SetHealth(hp);

            // HP降为0时，自动销毁此怪
            if (hp <= 0)
            {
                Destroy(this.gameObject);
                
                // 玩有得分 + this.value
                game.SendMessage("AddScore", this.value);
            }
        }
    }


}
