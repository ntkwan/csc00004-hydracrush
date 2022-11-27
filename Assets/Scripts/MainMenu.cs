using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using MatchThreeEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private AudioClip ButtonClicked;

    [SerializeField] private AudioClip ButtonOut;

    [SerializeField] private AudioSource audioSource;

    public loadCredits LoadCredits;
    public loadTutorial LoadTutorial;

    public void NextSceneTwo(){
        SceneManager.LoadScene("Scene_2");
    }

    public void NextSceneOne(){
        Application.Quit();
    }

    public void NextSceneThree(){
        LoadCredits.Setup();
    }

    public void NextSceneFour(){
        LoadTutorial.Setup();
    }

    public void NewGame(){
        audioSource.PlayOneShot(ButtonOut);
        Invoke("NextSceneTwo", 1.1f);
    }

    public void QuitGame(){
        audioSource.PlayOneShot(ButtonClicked);
        Invoke("NextSceneOne", 0.5f);
    }

    public void Credits(){
        audioSource.PlayOneShot(ButtonClicked);
        Invoke("NextSceneThree", 0.5f);
    }

    public void Tutorial(){
        audioSource.PlayOneShot(ButtonClicked);
        Invoke("NextSceneFour", 0.5f);
    }
}
