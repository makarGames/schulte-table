using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager S;

    [SerializeField] private Text bestTime;
    [SerializeField] private Text avgTime;

    private int _playCounter;
    private int playCounter
    {
        get
        {
            return _playCounter;
        }
        set
        {
            _playCounter = value;
            PlayerPrefs.SetInt("PlayCounter", _playCounter);
        }
    }

    static private float _bestTimeValue;
    private float bestTimeValue
    {
        get
        {
            return _bestTimeValue;
        }
        set
        {
            _bestTimeValue = value;
            PlayerPrefs.SetFloat("BestTime", _bestTimeValue);
            bestTime.text = "BEST\n" + _bestTimeValue.ToString("0.00");
        }
    }

    static private float _avgTimeValue;
    private float avgTimeValue
    {
        get
        {
            return _avgTimeValue;
        }
        set
        {
            _avgTimeValue = value;
            PlayerPrefs.SetFloat("AvgTime", _avgTimeValue);
            avgTime.text = "AVG\n" + _avgTimeValue.ToString("0.00");
        }
    }

    private void Awake()
    {
        if (S == null)
            S = this;
    }

    private void Start()
    {
        bestTimeValue = PlayerPrefs.GetFloat("BestTime", 0);
        avgTimeValue = PlayerPrefs.GetFloat("AvgTime", 0);
        playCounter = PlayerPrefs.GetInt("PlayCounter", 0);
    }

    public void StopCounter(float time)
    {
        if (time < bestTimeValue || bestTimeValue == 0) bestTimeValue = time;

        avgTimeValue = (avgTimeValue * playCounter + time) / (playCounter + 1);
        playCounter++;
    }
}
