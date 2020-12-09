using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    void Update() {
        if (!Pause.pause)
        {
            transform.Rotate(new Vector3(0, 0, 300 * Time.deltaTime));
        }
    }
}
