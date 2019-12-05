using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    
    public int ScoreNow;
    public int HighestScore;
    [Header("水管")]
    public GameObject pipe;

    [Header("介面群組")]
    public GameObject goUI;

    [Header("分數介面")]
    public Text textScore;
    public Text textHighestScore;

    //public Chicken bird;

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

    public void AddScore(int add)
    {
        ScoreNow += add;
        textScore.text = ScoreNow.ToString();
        SetHighestScore();
        //bird.aud.PlayOneShot(bird.soundAdd);
    }

    public void SetHighestScore()
    {
        HighestScore = PlayerPrefs.GetInt("最高分數");

        if (ScoreNow > HighestScore)
        {           
            HighestScore = ScoreNow;
            PlayerPrefs.SetInt("最高分數", HighestScore);
            
        }
        textHighestScore.text = HighestScore.ToString();

    }

    public void GameOver()
    {
        goUI.SetActive(true);
        floor.Speed = 0;
    }


    // Start is called before the first frame update
    void Start()
    {
        // 延遲重複調用
        InvokeRepeating("BornPipe", 0, 1.5f);

        HighestScore = PlayerPrefs.GetInt("最高分數");
        textHighestScore.text = HighestScore.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
