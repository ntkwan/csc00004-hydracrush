using System.Collections;   
using UnityEngine.UI;
using UnityEngine;

public sealed class ScoreCounter : MonoBehaviour
{
    public static ScoreCounter Instance { get; private set; }

    [SerializeField] private Text Score_Text;
    
    private int _score;

    public int Score
    {
        get => _score;
        
        set
        {
            if (_score == value) return;

            _score = value;

            Score_Text.text = ((int)_score).ToString(); 
        }
    }


    private void Awake() => Instance = this;
}
