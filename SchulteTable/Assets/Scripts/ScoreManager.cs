using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager S;

    [SerializeField] private Text bestTime;

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

    private float _bestTimeValue;
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

    private void Awake()
    {
        if (S == null)
            S = this;

        bestTimeValue = PlayerPrefs.GetFloat("BestTime", 0);
        playCounter = PlayerPrefs.GetInt("PlayCounter", 1);
    }

    public void StopRound(float time)
    {
        if (time < bestTimeValue || bestTimeValue == 0)
            bestTimeValue = time;

        playCounter++;
    }
}
