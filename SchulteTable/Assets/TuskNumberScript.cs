using UnityEngine;
using UnityEngine.UI;

public class TuskNumberScript : MonoBehaviour
{
    public static TuskNumberScript S;
    Text textNumber;

    [SerializeField] private int _counter;

    private int counter
    {
        get
        {
            return _counter;
        }
        set
        {
            _counter = value;
            textNumber.text = _counter.ToString();
        }
    }

    private void Awake()
    {
        textNumber = GetComponent<Text>();
    }

    private void Start()
    {
        if (S == null)
            S = this;
    }

    public void StartRound()
    {
        counter = 1;
    }

    public void Addition(int number)
    {
        if (counter == 25)
        {
            Timer.S.StopTimer();
            return;
        }
        if (number == counter)
        {
            counter++;
        }
    }
}
