using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public static bool pause;
    public GameObject button;
    public static int pauseScene;
    void Start()
    {
        pauseScene = 29;
        pause = false;
    }

    void Update()
    {
        if (StaySelected.lastSelected == button)
        {
            pause = true;
            if(!isSceneCurrentlyLoaded(pauseScene)){
                SceneManager.LoadSceneAsync(pauseScene, LoadSceneMode.Additive);
            }
            
        }
        else
        {
            pause = false;
            if(isSceneCurrentlyLoaded(pauseScene))
                SceneManager.UnloadSceneAsync(pauseScene);
        }
    }

    bool isSceneCurrentlyLoaded(int scene) {
        for(int i = 0; i<SceneManager.sceneCount; ++i) {
            Scene s = SceneManager.GetSceneAt(i);
            if(s.buildIndex == scene) {
                return true;
            }
        }
        return false;
    }
}
