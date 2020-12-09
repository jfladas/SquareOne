using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Code_2 : MonoBehaviour
{
    static GameObject num1;
    static GameObject num2;
    static GameObject num3;
    void Start()
    {
        num1 = GameObject.Find("code_1_1");
        num2 = GameObject.Find("code_1_2");
        num3 = GameObject.Find("code_1_3");
    }
    void Update()
    {
        if (num1.GetComponent<Counter>().num == 4 && num2.GetComponent<Counter>().num == 1 && num3.GetComponent<Counter>().num == 6)
        {
            LevelData.aD[8] = 1;
            LevelData.aU[13] = 1;
        }
    }
}
