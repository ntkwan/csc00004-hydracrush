using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadTutorial : MonoBehaviour
{
    public void Setup(){
        gameObject.SetActive(true);
    }

    public void BackButton(){
        gameObject.SetActive(false);
    }
}
