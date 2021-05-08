using UnityEngine;
using UnityEngine.UI;

public class TuskNumberScript : MonoBehaviour
{
    public static TuskNumberScript S;

    [SerializeField] private int _counter;

    private Text textNumber;
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
        if (S == null)
            S = this;
        textNumber = GetComponent<Text>();
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
