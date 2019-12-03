using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : MonoBehaviour
{

    public GameObject goScore, goGM;

    [Header("跳躍高度"),Range(0,1000)]
    public float JumpHeight;
    public bool dead;

    [Header("剛體")]
    public Rigidbody2D rig;

    public GameManager gm;

    private void Jump()
    {
        if (dead) { return; }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            print("按下左鍵");
            goGM.SetActive(true);
            goScore.SetActive(true);
            rig.gravityScale = 1;

            //剛體.睡覺
            rig.Sleep();
            rig.AddForce(new Vector2(0, JumpHeight));


        }

        rig.SetRotation(5 * rig.velocity.y);
    }

    private void DeadOrNot()
    {
        dead = true;
        gm.GameOver();
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.gameObject.name);

        DeadOrNot();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        DeadOrNot();
    }
}
