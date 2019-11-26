using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor : MonoBehaviour
{
    [Header("速度"),Range(0,10)]
    public float Speed;

    [Header("地板")]
    public Transform Floor;

    private void Move()
    {
        Floor.Translate(new Vector3(-Speed*Time.deltaTime, 0, 0));


    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public virtual void Test()
    {
        print("父類別");
    }
}
