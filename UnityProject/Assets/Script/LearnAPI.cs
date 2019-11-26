using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnAPI : MonoBehaviour
{
    public Transform tranA;
    public Transform tranB;
    public SpriteRenderer spriteA;


    // Start is called before the first frame update
    void Start()
    {
        print("輸出！");

        Debug.Log("輸出!!!!!!");

        print("隨機變數: " + Random.Range(50.5f, 100.5f));

        tranA.position = new Vector3(-3, 0, 0);
        tranA.Rotate(0, 0, 60);

        spriteA.flipX = true;
        spriteA.flipY = true;

    }

    // Update is called once per frame
    void Update()
    {
        print(Input.inputString);

        if (Input.GetKeyDown("s"))
        {
            print("玩家按下了 s ");
        }

        print(tranA.position);
        print(tranB.position);


    }
}
