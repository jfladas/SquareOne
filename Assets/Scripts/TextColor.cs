using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextColor : MonoBehaviour
{
    public Color colorD;
    public Color colorL;
    void Update()
    {
        if (DarkMode.dark)
        {
            GetComponent<Text>().color = colorD;
        }
        else
        {
            GetComponent<Text>().color = colorL;
        }
    }
}
