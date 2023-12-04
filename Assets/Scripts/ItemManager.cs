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
        nar = false;
        dar = false;
        but = false;
        pau = false;
        mus = false;
        tel = false;
    }
    void Update()
    {
        if (!nar)
        {
            nar_b.GetComponent<Button>().interactable = false;
            nar_b.GetComponent<GridLayoutGroup>().cellSize = new Vector2(0, 0);
        }else{
            nar_b.GetComponent<Button>().interactable = true;
            nar_b.GetComponent<GridLayoutGroup>().cellSize = new Vector2(100, 100);
        }
        if (!dar)
        {
            dar_b.GetComponent<Button>().interactable = false;
            dar_b.GetComponent<GridLayoutGroup>().cellSize = new Vector2(0, 0);
        }else{
            dar_b.GetComponent<Button>().interactable = true;
            dar_b.GetComponent<GridLayoutGroup>().cellSize = new Vector2(110, 110);
        }
        if (!but)
        {
            but_b.GetComponent<Button>().interactable = false;
            but_b.GetComponent<GridLayoutGroup>().cellSize = new Vector2(0, 0);
        }else{
            but_b.GetComponent<Button>().interactable = true;
            but_b.GetComponent<GridLayoutGroup>().cellSize = new Vector2(90, 90);
        }
        if (!pau)
        {
            pau_b.GetComponent<Button>().interactable = false;
            pau_b.GetComponent<GridLayoutGroup>().cellSize = new Vector2(0, 0);
        }else{
            pau_b.GetComponent<Button>().interactable = true;
            pau_b.GetComponent<GridLayoutGroup>().cellSize = new Vector2(80, 90);
        }
        if (!mus)
        {
            mus_b.GetComponent<Button>().interactable = false;
            mus_b.GetComponent<GridLayoutGroup>().cellSize = new Vector2(0, 0);
        }else{
            mus_b.GetComponent<Button>().interactable = true;
            mus_b.GetComponent<GridLayoutGroup>().cellSize = new Vector2(90, 90);
        }
        if (!tel)
        {
            tel_b.GetComponent<Button>().interactable = false;
            tel_b.GetComponent<GridLayoutGroup>().cellSize = new Vector2(0, 0);
        }else{
            tel_b.GetComponent<Button>().interactable = true;
            tel_b.GetComponent<GridLayoutGroup>().cellSize = new Vector2(110, 110);
        }
    }
}
