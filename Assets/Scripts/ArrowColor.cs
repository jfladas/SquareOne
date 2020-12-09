using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowColor : MonoBehaviour
{
    public SpriteRenderer sr;
    public Sprite spriteD;
    public Sprite spriteL;
    void Update()
    {
        if (DarkMode.dark){
            sr.sprite = spriteD;
        } else {
            sr.sprite = spriteL;
        }
    }
}
