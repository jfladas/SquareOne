using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnyManager : MonoBehaviour{
    public static AnyManager anyManager;
    public static int currentScene;
    public static int [,] rooms;
    public static int zPos;
    int[] row;
    bool gameStart;
    static bool no;
    int nextRoom;
    static int cRoomX;
    static int cRoomY;
    void Awake(){
        if (!gameStart){
            gameStart = true;
            no = false;
            currentScene = 2;
            cRoomX = -1;
            cRoomY = -1;
            anyManager = this;
            SceneManager.LoadSceneAsync(1, LoadSceneMode.Additive);
            SceneManager.LoadSceneAsync(2, LoadSceneMode.Additive);
            zPos = 0;
            rooms = new int [,] { 
                { 2, 3, 4, 5, 6}, 
                { 7, 8, 9,10,11}, 
                {12,13,14,15,16}, 
                {17,18,19,20,21}, 
                {22,23,24,25,26} 
            };
            UpdateRooms();

        }
    }
    void Update(){
        for (int x = 0; x < 5; ++x){
            for (int y = 0; y < 5; ++y){
                if (rooms[y, x].Equals(currentScene)){
                    cRoomX = x;
                    cRoomY = y;
                }
            }
        }
    }
    public void UpdateRooms(){
        switch(zPos){
            case 0:
                row = new int [] {22,23,24,25,26};
                break;
            case 1:
                row = new int [] {27,22,23,24,25};
                break;
            case 2:
                row = new int [] {26,27,22,23,24};
                break;
            case 3:
                row = new int [] {25,26,27,22,23};
                break;
            case 4:
                row = new int [] {24,25,26,27,28};
                break;
            case 5:
                row = new int [] {23,24,25,26,27};
                break;
            default:
                row = new int [] {22,23,24,25,26};
                break;
        }
        for (int i = 0; i < 5; i++) {
            rooms[4,i] = row[i];
        }
    }
    public void LoadNext(int dir){
        //0=up 1=right 2=down 3=left
        if(cRoomX!=-1&&cRoomY!=-1){
            int x = cRoomX;
            int y = cRoomY;
            int xN = x;
            int yN = y;
            switch (dir){
                case 0:
                    yN--;
                    break;
                case 1:
                    xN++;
                    break;
                case 2:
                    yN++;
                    break;
                case 3:
                    xN--;
                    break;
                default:
                    no = true;
                    break;
            }
            if(!no){
                currentScene = rooms[yN,xN];
                SceneManager.LoadSceneAsync(currentScene, LoadSceneMode.Additive);
                UnloadScene(rooms[y,x]);
            }else{
                no = false;
            }
        }
    }
    public void UnloadScene(int scene){
        StartCoroutine(Unload(scene));
    }

    IEnumerator Unload(int scene){
        yield return null;
        SceneManager.UnloadSceneAsync(scene);
    }
}
