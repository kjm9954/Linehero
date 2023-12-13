using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonsterScore : MonoBehaviour
{
    public int score = 0;
    Text text_score;


    private void Awake()
    {
        text_score = GetComponent<Text>();
    }

    public void AddScore()
    {
        score++;
        UpdateText();
    }
    public void UpdateText()
    {
        text_score.text = score.ToString();
    }

    public int GetScore()
    {
        return score;
    }

}
