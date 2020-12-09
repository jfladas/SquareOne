using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelColor : MonoBehaviour
{
    public Sprite spriteD;
    public Sprite spriteL;
    void Update()
    {
        if (DarkMode.dark)
        {
            gameObject.GetComponent<Image>().sprite = spriteD;
        }
        else
        {
            gameObject.GetComponent<Image>().sprite = spriteL;
        }
    }
}
