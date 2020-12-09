using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextRoom : MonoBehaviour
{
    int dir;
    void Start(){
        transform.localScale = new Vector3(0.5f, 0.5f, 1f);
    }
    void OnMouseDown(){
        transform.localScale = new Vector3(0.4f, 0.4f, 1f);
        switch(gameObject.tag){
            case "u":
                dir = 0;
                break;
            case "r":
                dir = 1;
                break;
            case "d":
                dir = 2;
                break;
            case "l":
                dir = 3;
                break;
            default:
                dir = -1;
                break;
        }
        AnyManager.anyManager.LoadNext(dir);
    }
}
