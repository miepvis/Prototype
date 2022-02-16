using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timer;
    TimeSpan time = new TimeSpan(int hours, int minutes, int seconds);

    void Update()
    {
        time.Add()
    }
}
