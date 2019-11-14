using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnMethod : MonoBehaviour
{
    /// <summary>
    /// 開車子
    /// </summary>
    private void Drive()
    {
        print("The car is driving");
    }

    // Start is called before the first frame update
    void Start()
    {
        Drive();
        Drive();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
