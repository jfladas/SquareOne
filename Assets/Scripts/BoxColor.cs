using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoxColor : MonoBehaviour
{
    public Sprite spriteD;
    public Sprite hoverD;
    public Sprite selectedD;
    public Sprite spriteL;
    public Sprite hoverL;
    public Sprite selectedL;
    SpriteState lght = new SpriteState();
    SpriteState dark = new SpriteState();
    void Start(){
        lght.highlightedSprite = hoverL;
        lght.pressedSprite = selectedL;
        lght.selectedSprite = selectedL;
        lght.disabledSprite = spriteL;

        dark.highlightedSprite = hoverD;
        dark.pressedSprite = selectedD;
        dark.selectedSprite = selectedD;
        dark.disabledSprite = spriteD;
    }
    void Update()
    {
        if (DarkMode.dark)
        {
            GetComponent<Button>().spriteState = dark;
            gameObject.GetComponent<Image>().sprite = spriteD;
        }
        else
        {
            GetComponent<Button>().spriteState = lght;
            gameObject.GetComponent<Image>().sprite = spriteL;
        }
    }
}
