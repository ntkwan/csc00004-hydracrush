using System.Collections;   
using UnityEngine.UI;
using UnityEngine;

public sealed class TimeCounter : MonoBehaviour
{
    public static TimeCounter Instance { get; private set; }

    [SerializeField] private Text Time_Text;

    private double _time;

    public double Time
    {
        get => _time;
        
        set
        {
            if (_time == value) return;

            _time = value;

            Time_Text.text = ((int)_time).ToString();
        }
    }


    private void Awake() => Instance = this;
}
