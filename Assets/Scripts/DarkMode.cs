using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DarkMode : MonoBehaviour
{
    public static bool dark;
    public GameObject button;
    void Start(){
        dark = false;
    }
    void Update(){
        if(StaySelected.lastSelected == button){
            dark = true;
        }else{
            dark = false;
        }
    }
}