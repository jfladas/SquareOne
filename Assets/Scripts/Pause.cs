using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public static bool pause;
    public GameObject button;
    void Start()
    {
        pause = false;
    }
    void Update()
    {
        if (StaySelected.lastSelected == button)
        {
            pause = true;
        }
        else
        {
            pause = false;
        }
    }
}
