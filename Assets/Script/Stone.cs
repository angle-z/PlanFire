using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    public float speed = 4.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dx = speed * Time.deltaTime;
        float dy = speed * Time.deltaTime;
        transform.Translate(-dx, -dy, 0,Space.Self);
        //判断陨石是否在游戏界面外

        Vector3 sp = Camera.main.WorldToScreenPoint(transform.position);
        sp.z = 0;
        if (sp.y < 0||sp.x<0)
        {
            Destroy(this.gameObject);

        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag.Equals("Player"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(2);

            //Application.Quit();
            Debug.Log("游戏结束");
        }
    }
}
