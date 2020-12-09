using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    bool selected = false;
    public SpriteRenderer sr;
    public Sprite spriteD;
    public Sprite selectedD;
    public Sprite spriteL;
    public Sprite selectedL;
    void Update()
    {
        if (DarkMode.dark)
        {
            if(selected){
                sr.sprite = selectedD;
            }else{
                sr.sprite = spriteD;
            }
        }else{
            if (selected)
            {
                sr.sprite = selectedL;
            }else{
                sr.sprite = spriteL;
            }
        }
    }
    void OnMouseDown() {
        if(selected){
            selected = false;
        }else{
            selected = true;
        }
    }
}
