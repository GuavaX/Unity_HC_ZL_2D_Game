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

    [Header("音效區域")]
    public AudioSource aud;
    public AudioClip soundJump, soundHit, soundAdd;

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

            aud.PlayOneShot(soundJump, 2f);

        }

        rig.SetRotation(5 * rig.velocity.y);
    }

    private void DeadOrNot()
    {
        if (dead) { return; }
        dead = true;
        gm.GameOver();
    }

    private void PassPipe()
    {
        if (dead) { return; }
        aud.PlayOneShot(soundAdd, 2f);
        gm.AddScore(1);
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
        aud.PlayOneShot(soundHit, 2f);
        DeadOrNot();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (dead) { return; }
        if ((collision.gameObject.name == "水管 - 上") || (collision.gameObject.name == "水管 - 下"))
        {
            DeadOrNot();
            aud.PlayOneShot(soundHit, 2f);
        }

        if (collision.gameObject.name == "加分區域")
        {
            PassPipe();
        }


    }
}
