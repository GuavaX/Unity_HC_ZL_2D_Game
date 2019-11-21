using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int ScoreNow;
    int HighestScore;
    [Header("水管")]
    public GameObject pipe;

    /// <summary>
    /// 生成水管
    /// </summary>
    public void BornPipe()
    {
        float y = Random.Range(-1.1f, 1.9f);

        Vector3 pos = new Vector3(4.5f, y, 0);
        Quaternion rot = new Quaternion(0, 0, 0, 0);

        Object.Instantiate(pipe, pos, rot);

    }

    public void AddScore()
    {

    }

    public void SetHighestScore()
    {

    }

    public void GameOver()
    {

    }


    // Start is called before the first frame update
    void Start()
    {
        BornPipe();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
