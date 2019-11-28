using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnOperator : MonoBehaviour
{
    public int a = 10, b = 3;
    public int c = 9, d = 1;
    // Start is called before the first frame update
    void Start()
    {
        print(a + b);
        print(a - b);
        print(a * b);
        print(a / b);
        print(a % b);

        print(c > d);
        print(c < d);
        print(c >= d);
        print(c <= d);
        print(c == d);
        print(c != d);

        //邏輯運算子&&
        print(true  && true );
        print(true  && false);
        print(false && true );
        print(false && false);

        //邏輯運算子||
        print(true || true);
        print(true || false);
        print(false || true);
        print(false || false);



    }
    private void Jump()
    {
        
    }

    void OnMouseDown()
    {
        print("是在哈囉");
        //transform.position = new Vector2(0, 0);//點擊時回到(0,0)
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
