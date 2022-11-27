using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    [SerializeField] public Text pointsText;

    [SerializeField] public Text hPointsText;

    [SerializeField] private AudioClip ButtonClicked;

    [SerializeField] private AudioClip ButtonOut;

    [SerializeField] private AudioSource audioSource;

    
    public void Setup(int score){
        gameObject.SetActive(true);
        pointsText.text = score.ToString();
        hPointsText.text = PlayerPrefs.GetInt("HScore").ToString();
    }

    private void NextSceneTwo(){
        SceneManager.LoadScene("Scene_2");
    }

    private void NextSceneOne(){
        SceneManager.LoadScene("Scene_1");
    }

    public void RestartButton(){
        audioSource.Stop();
        audioSource.PlayOneShot(ButtonOut);
        Invoke("NextSceneTwo", 1.1f);
    }

    public void MainMenuButton(){
        audioSource.Stop();
        audioSource.PlayOneShot(ButtonClicked);
        Invoke("NextSceneOne", 0.5f);
    }
    
}
