using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : MonoBehaviour
{
    [Header("跳躍高度"),Range(0,1000)]
    public float JumpHeight;
    public bool dead;

    [Header("剛體")]
    public Rigidbody2D rig;

    private void Jump()
    {
        if (Input.GetKeyDown("space"))
        {
            rig.AddForce(new Vector3(0, JumpHeight));
        }
    }

    private void DeadOrNot()
    {

    }

    private void PassPipe()
    {

    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
    }
}
