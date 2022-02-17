using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    /// <summary>
    /// Match duration in seconds.
    /// </summary>
    [SerializeField] float matchDuration;
    [SerializeField] TextMeshProUGUI textField;

    void Update()
    {
        matchDuration -= Time.deltaTime;

        string minutes = Math.Floor(matchDuration / 60).ToString("00");
        string seconds = (matchDuration % 60).ToString("00");

        textField.text = string.Format("{0}\n{1}", minutes, seconds);
    }
}
