using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static Timer S;
    public bool startTimer;

    private Text textTimer;
    private float _timer;
    private float timer
    {
        get
        {
            return _timer;
        }
        set
        {
            _timer = value;
            textTimer.text = _timer.ToString("0.00");
        }
    }

    private void Awake()
    {
        if (S == null)
            S = this;

        textTimer = GetComponent<Text>();
        startTimer = false;
    }

    private void FixedUpdate()
    {
        if (startTimer)
        {
            timer += Time.deltaTime;
        }
    }

    public void StartTimer()
    {
        timer = 0;
        startTimer = true;
    }

    public void StopTimer()
    {
        startTimer = false;
        ScoreManager.S.StopRound(timer);
    }
}
