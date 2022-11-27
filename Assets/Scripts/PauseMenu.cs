using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{    
    public void SetPause(){
        gameObject.SetActive(true);
    }

    private void NextSceneTwo(){
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void SetResume(){
       NextSceneTwo();
    }

    private void NextSceneOne(){
        SceneManager.LoadScene("Scene_1");
        Time.timeScale = 1;
    }

    public void SetMenu(){
        NextSceneOne();
    }
}
