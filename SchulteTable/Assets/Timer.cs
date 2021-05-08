using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static Timer S;
    private Text textTimer;

    public bool startTimer;

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
        textTimer = GetComponent<Text>();
    }
    private void Start()
    {
        if (S == null)
            S = this;
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
        ScoreManager.S.StopCounter(timer);
    }
}
