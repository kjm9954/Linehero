using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject mon_score;
    public GameObject time_score;
    public Text mon_text;
    public Text time_text;

    string MonScoreKey = "Monster";
    string Min_TimeScoreKey = "M_Time";
    string Sec_TimeScoreKey = "S_Time";

    private void Start()
    {
        if (mon_text != null && time_text != null)
        {
            mon_text.GetComponent<Text>().text = PlayerPrefs.GetInt(MonScoreKey).ToString();
            time_text.GetComponent<Text>().text = string.Format("{0:D2}:{1:D2}", PlayerPrefs.GetInt(Min_TimeScoreKey), (int)PlayerPrefs.GetFloat(Sec_TimeScoreKey));
        }
    }

    public void Update()
    {
        if (mon_score != null && time_score != null) 
        {
            Get_MonsterHighscoer();
            Get_MinTimeScore();
            Get_SecTimeScore();
            Set_HighScore();
        }
    }
    public int Get_MonsterHighscoer()
    {
        int highScore = PlayerPrefs.GetInt(MonScoreKey);

        return highScore;
    }

    public int Get_MinTimeScore() 
    {
        int Min_timeScore = PlayerPrefs.GetInt(Min_TimeScoreKey);
       

        return Min_timeScore;
    }

    public float Get_SecTimeScore()
    {
        float Sec_timeScore = PlayerPrefs.GetFloat(Sec_TimeScoreKey);

        return Sec_timeScore;
    }

    public void Set_HighScore()
    {
        if (mon_score.GetComponent<MonsterScore>().score > Get_MonsterHighscoer()) 
        {
            PlayerPrefs.SetInt(MonScoreKey, mon_score.GetComponent<MonsterScore>().score);
        }

        if (time_score.GetComponent<TimeScore>()._Min > Get_MinTimeScore()) 
        {
            PlayerPrefs.SetInt(Min_TimeScoreKey, time_score.GetComponent<TimeScore>()._Min);
            PlayerPrefs.SetFloat(Sec_TimeScoreKey, time_score.GetComponent<TimeScore>()._Sec);
        }
        else
        {
            if (time_score.GetComponent<TimeScore>()._Sec >  Get_SecTimeScore())
            {
                PlayerPrefs.SetFloat(Sec_TimeScoreKey, time_score.GetComponent<TimeScore>()._Sec);
            }
        }
    }
}
