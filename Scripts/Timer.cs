
using System;
using System.Collections;

using TMPro;

using Unity.VisualScripting;

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private TMP_Text output;

    [SerializeField] private int maxSeconds;

    [SerializeField] private UnityEvent onEndTimer;
    [SerializeField] private UnityEvent onStartTimer;

    public void StartTimer()
    {
        RestartTimer();

        onStartTimer?.Invoke();
        StartCoroutine(Work());
    }

    private void RestartTimer()
    {
        output.text = $"3 минут   0 секунд";
    }

    private IEnumerator Work()
    {
        var seconds = maxSeconds;
        while(seconds > 0)
        {
            seconds--;
            TimeSpan time = TimeSpan.FromSeconds(seconds);
            output.text = $"{time.Minutes} минут   {time.Seconds} секунд";

            yield return new WaitForSeconds(1);
        }
        onEndTimer?.Invoke();
    }
}
