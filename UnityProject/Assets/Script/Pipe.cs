using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : floor
{

    private void OnBecameInvisible()
    {
        print("看不到");
        Destroy(gameObject);
    }

    private void OnBecameVisible()
    {
        //print("看到惹");
    }

    public override void Test()
    {
        print("子類別");
    }
}
