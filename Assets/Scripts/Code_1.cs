using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Code_1 : MonoBehaviour
{
    static GameObject num1;
    static GameObject num2;
    static GameObject num3;
    void Start() {
        num1 = GameObject.Find("code_1_1");
        num2 = GameObject.Find("code_1_2");
        num3 = GameObject.Find("code_1_3");
    }
    void Update()
    {
        if(num1.GetComponent<Counter>().num == 2 && num2.GetComponent<Counter>().num == 5 &&num3.GetComponent<Counter>().num == 4){
            LevelData.aL[8] = 1;
            LevelData.aD[2] = 1;
        }
    }
}