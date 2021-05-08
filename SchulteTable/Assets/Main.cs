using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public List<GameObject> cells;

    private List<int> numbers = new List<int>();

    public void SettingValues()
    {
        int index;
        for (int i = 1; i < cells.Count + 1; i++)
        {
            numbers.Add(i);
        }

        for (int i = 0; i < cells.Count; i++)
        {
            index = Random.Range(0, numbers.Count);
            cells[i].GetComponent<Number>().number = numbers[index];
            numbers.RemoveAt(index);
        }
    }
}
