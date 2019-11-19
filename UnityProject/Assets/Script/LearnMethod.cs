using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnMethod : MonoBehaviour
{
    /// <summary>
    /// 開車子
    /// </summary>
    private void Drive(int speed)
    {
        print("Sound!!!");
        print("The car is driving with " + speed);
    }

    private void Shoot (int count = 1,string direction="前方",string prop="無")
    {
        print("弓箭數量：" + count);
        print("弓箭方向：" + direction);
        print("弓箭屬性：" + prop);
    }

    private string PrintName(string name)
    {
        return "Hello~ " + name + " 你好";
    }

    // Start is called before the first frame update
    void Start()
    {
        Drive(99);
        Drive(999);
        Shoot();
        Shoot(2);
        Shoot(99, "四面八方");
        Shoot(666, prop: "木火雙屬性");

        print(PrintName("Ray"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
