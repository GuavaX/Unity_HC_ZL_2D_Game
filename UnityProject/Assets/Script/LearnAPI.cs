using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnAPI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("輸出！");

        Debug.Log("輸出!!!!!!");

        print("隨機變數: " + Random.Range(50.5f, 100.5f));

        
    }

    // Update is called once per frame
    void Update()
    {
        print(Input.inputString);

        if (Input.GetKeyDown("s"))
        {
            print("玩家按下了 s ");
        }

        
    }
}
