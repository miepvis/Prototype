using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField] internal Scores score;

    private void OnTriggerEnter(Collider other)
    {
        AddScore();
    }

    internal virtual void AddScore()
    {
        Debug.Log("Forgot to change this line.");
    }
}
