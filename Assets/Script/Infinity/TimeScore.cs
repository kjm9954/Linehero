using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class TimeScore : MonoBehaviour
{
    public float _Sec;
    public int _Min;
    Text text_score;
    // Start is called before the first frame update

    private void Awake()
    {
        text_score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Timer();
    }

    void Timer()
    {
        _Sec += Time.deltaTime;
        text_score.text = string.Format("{0:D2}:{1:D2}", _Min, (int)_Sec);
        if ((int)_Sec > 59) 
        {
            _Sec = 0;
            _Min++;
        }
    }
}
