using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelData : MonoBehaviour{
    // 0 = off, 1 = on, 2 = never on
    public static int[] aU = {
        2, 2, 2, 2, 2,
        1, 1, 1, 1, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        1
    };
    public static int[] aR = {
        1, 1, 1, 0, 2,
        0, 0, 1, 0, 2,
        0, 0, 0, 0, 2,
        0, 0, 0, 0, 2,
        0, 0, 0, 0, 2,
        0
    };
    public static int[] aD = {
        0, 0, 0, 1, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        2, 2, 2, 2, 2,
        2
    };
    public static int[] aL = {
        2, 1, 1, 1, 0,
        2, 0, 0, 0, 0,
        2, 0, 0, 0, 0,
        2, 0, 0, 0, 0,
        2, 0, 0, 0, 0,
        0
    };
}
