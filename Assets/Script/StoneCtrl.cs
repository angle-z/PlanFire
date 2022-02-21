using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneCtrl : MonoBehaviour
{
    public GameObject StonePrefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateStone", 0.1f, 1.2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void CreateStone()
    {
        float x = Random.Range(0, 19);
        float y = 6;
        GameObject stone = Instantiate(StonePrefab);
        stone.transform.position = new Vector3(x, y, 0);
    }
}
