using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    int currentSceneIndex;
     private void Start() {
        currentSceneIndex=SceneManager.GetActiveScene().buildIndex;
    }

    public void ReloadScene(){
        SceneManager.LoadScene(currentSceneIndex);
    }

    public void LoadNextScene(){
        int nextSceneIndex=currentSceneIndex+1;
        if(nextSceneIndex==SceneManager.sceneCountInBuildSettings){
            nextSceneIndex=0;
        }
        SceneManager.LoadScene(nextSceneIndex);
    }
}
