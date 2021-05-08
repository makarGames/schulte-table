using UnityEngine;
using UnityEngine.UI;

public class Number : MonoBehaviour
{
    [SerializeField] private Text textNumber;

    private int _number;
    public int number
    {
        get
        {
            return _number;
        }
        set
        {
            _number = value;
            textNumber.text = _number.ToString();
        }
    }

    public void GetClicked()
    {
        if (Timer.S.startTimer == true)
            TuskNumberScript.S.Addition(number);
    }
}
