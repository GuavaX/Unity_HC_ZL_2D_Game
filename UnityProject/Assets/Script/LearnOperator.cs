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


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
