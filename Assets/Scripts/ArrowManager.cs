using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowManager : MonoBehaviour
{
    static GameObject arrow;

    void Update(){
        try{
            if(LevelData.aU[AnyManager.currentScene-2]==1){
                enableTag("u");
            }else if(LevelData.aU[AnyManager.currentScene-2]==0){
                disableTag("u");
            }
            if(LevelData.aR[AnyManager.currentScene-2]==1){
                enableTag("r");
            }else if(LevelData.aR[AnyManager.currentScene-2]==0){
                disableTag("r");
            }
            if(LevelData.aD[AnyManager.currentScene-2]==1){
                enableTag("d");
            }else if(LevelData.aD[AnyManager.currentScene-2]==0){
                disableTag("d");
            }
            if(LevelData.aL[AnyManager.currentScene-2]==1){
                enableTag("l");
            }else if(LevelData.aL[AnyManager.currentScene-2]==0){
                disableTag("l");
            }
        }catch{}
    }

    void enableTag(string x){
        arrow = GameObject.FindGameObjectsWithTag(x)[0];
            arrow.GetComponent<SpriteRenderer>().enabled = true;
            arrow.GetComponent<BoxCollider2D>().enabled = true;
    }
    void disableTag(string x){
        arrow = GameObject.FindGameObjectsWithTag(x)[0];
            arrow.GetComponent<SpriteRenderer>().enabled = false;
            arrow.GetComponent<BoxCollider2D>().enabled = false;
    }
}