using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoomLetter : MonoBehaviour{
    public Text txt;
    public string[] letters;
    
    void Update(){
        txt.text = letters[AnyManager.currentScene-2];
    }
}
