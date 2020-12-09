using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayTime : MonoBehaviour
{
    public static int sec = 0;
    public bool stopTime = false;
    public Text txt;
    public bool pause;
    /*
    void Start()
    {
        StartCoroutine(Loop());
    }

    IEnumerator Loop(){
        while(!stopTime){
            txt.text = Time();
            yield return new WaitForSeconds(1);
            if(pause){
                if(!Pause.pause){
                    sec++;
                }
            }else{
                sec++;
            }
        }
    }
    string Time(){
        TimeSpan time = TimeSpan.FromSeconds(sec);
        DateTime dateTime = DateTime.Today.Add(time);
        return dateTime.ToString("hh:mm:ss");
    }*/

    float timer = 0.0f;
 
    void Update()
    {
        timer += Time.deltaTime;
        int secs = Convert.ToInt32(timer);
        txt.text = secs.ToString();
    }
}
