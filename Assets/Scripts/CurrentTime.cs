using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentTime : MonoBehaviour
{
    public Text txt;
    void Update()
    {
        txt.text = System.DateTime.Now.ToLongTimeString();
    }
}
