using TMPro;

using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    [SerializeField]
    private TMP_Text output;

    private int count = 0;

    public void RestartCounter()
    {
        count = 0;
        output.text = count.ToString();
    }

    public void AddPoint()
    {
        count++;
        output.text = count.ToString();
    }

    public void RemovePoint()
    {
        count--;
        output.text = count.ToString();
    }
}
