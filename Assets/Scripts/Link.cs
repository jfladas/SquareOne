using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Link : MonoBehaviour
{
    public string link;
    void OnMouseDown() {
        Application.OpenURL(link);
    }
}
