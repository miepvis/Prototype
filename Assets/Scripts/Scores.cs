using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Scores : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textFieldLeft;
    [SerializeField] TextMeshProUGUI textFieldRight;

    private int scoreLeft;

    public int ScoreLeft
    {
        get { return scoreLeft; }
        set {
            textFieldLeft.text = value.ToString();
            scoreLeft = value;
        }
    }

    private int scoreRight;

    public int ScoreRight
    {
        get { return scoreRight; }
        set {
            textFieldRight.text = value.ToString();
            scoreRight = value;
        }
    }
}
