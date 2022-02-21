using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonsterCtrl : MonoBehaviour
{
    public GameObject MonsterPrefab;
    public Sprite[] images;
    public float IncreseSpeed=2f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateMonster", 0.1f, IncreseSpeed);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IncreseSpeed > 0.2f)
        {
            IncreseSpeed = IncreseSpeed - 0.01f;
        }
        else
        {
            IncreseSpeed = 0.2f;
        }
    }
    void CreateMonster()
    {
        float x = Random.Range(-5, 5);
        float y = 5;
        GameObject monster = Instantiate(MonsterPrefab);
        monster.transform.position = new Vector3(x, y, 0);
        //
        int index = Random.Range(0, images.Length);//6张图片
        SpriteRenderer renderer = monster.GetComponent<SpriteRenderer>();
        renderer.sprite = this.images[index];
        //
        Sprite sprite = this.images[index];
        float imageWidth = sprite.rect.width;//获取图像的实际宽度
        float scale = 120 / imageWidth;//设置为100像素，缩放比例
        monster.transform.localScale = new Vector3(scale, scale, scale);

        //
        


    }
    
}
