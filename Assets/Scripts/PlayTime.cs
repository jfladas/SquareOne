using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayTime : MonoBehaviour
{
    public static int sec = 0;
    public bool stop = false;
    public Text txt;
    int timer, ptimer, secs, hcalc, mcalc, scalc;
    string t, h, m, s;
    
    void Start () {
        timer = 0;
        ptimer = 0;
        InvokeRepeating("OutputTime", 1f, 1f);  //1s delay, repeat every 1s
    }

    void OutputTime() {
        timer++;
        if(stop && !Pause.pause){
            ptimer++;
        }
    }
    
    void Update()
    {
        if(stop){
            secs = ptimer;
        }else{
            secs = timer;
        }
        txt.text = FormatTime(secs);
    }

    string FormatTime(int secs){

        hcalc = (secs-(secs%3600))/3600;
        if(hcalc>99 || hcalc==0){
            h = "00";
        }else if(hcalc<10){
            h = "0" + hcalc.ToString();
        }else{
            h = hcalc.ToString();
        }

        mcalc = ((secs-3600*hcalc)-(secs%60))/60;
        if(mcalc==0){
            m = "00";
        }else if(mcalc<10){
            m = "0" + mcalc.ToString();
        }else{
            m = mcalc.ToString();
        }

        scalc = secs-3600*hcalc-60*mcalc;
        if(scalc==0){
            s = "00";
        }else if(scalc<10){
            s = "0" + scalc.ToString();
        }else{
            s = scalc.ToString();
        }

        return h + ":" + m + ":" + s;
    }
}
