using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCursor : MonoBehaviour
{
    public SpriteRenderer rend;
    void Start(){
        Cursor.visible = false;
    }
    void Update(){
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = cursorPos;

        if(Input.GetMouseButtonDown(0)){
            transform.localScale = new Vector3(0.12f, 0.12f, 1f);
        } else if(Input.GetMouseButtonUp(0)){
            transform.localScale = new Vector3(0.15f, 0.15f, 1f);
        }
    }
}
