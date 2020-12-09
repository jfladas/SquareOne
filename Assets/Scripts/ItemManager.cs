using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    public static bool nar;
    public static bool dar;
    public static bool but;
    public static bool pau;
    public static bool mus;
    public static bool tel;
    public GameObject nar_b;
    public GameObject dar_b;
    public GameObject but_b;
    public GameObject pau_b;
    public GameObject mus_b;
    public GameObject tel_b;
    void Start()
    {
        nar = true;
        dar = true;
        but = false;
        pau = true;
        mus = false;
        tel = false;
    }
    void Update()
    {
        if (!nar)
        {
            nar_b.GetComponent<Button>().interactable = false;
            nar_b.GetComponent<GridLayoutGroup>().cellSize = new Vector2(0, 0);
        }
        if (!dar)
        {
            dar_b.GetComponent<Button>().interactable = false;
            dar_b.GetComponent<GridLayoutGroup>().cellSize = new Vector2(0, 0);
        }
        if (!but)
        {
            but_b.GetComponent<Button>().interactable = false;
            but_b.GetComponent<GridLayoutGroup>().cellSize = new Vector2(0, 0);
        }
        if (!pau)
        {
            pau_b.GetComponent<Button>().interactable = false;
            pau_b.GetComponent<GridLayoutGroup>().cellSize = new Vector2(0, 0);
        }
        if (!mus)
        {
            mus_b.GetComponent<Button>().interactable = false;
            mus_b.GetComponent<GridLayoutGroup>().cellSize = new Vector2(0, 0);
        }
        if (!tel)
        {
            tel_b.GetComponent<Button>().interactable = false;
            tel_b.GetComponent<GridLayoutGroup>().cellSize = new Vector2(0, 0);
        }
    }
}
