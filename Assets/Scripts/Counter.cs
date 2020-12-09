using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
    public int num = 0;
    public SpriteRenderer sr;
    public Sprite[] sprites_d;
    public Sprite[] sprites_l;
    void Update()
    {
        if (DarkMode.dark){
            sr.sprite = sprites_d[num];
        }else{
            sr.sprite = sprites_l[num];
        }
    }
    void OnMouseDown()
    {
        num++;
        if(num==10){
            num = 0;
        }
    }
}
