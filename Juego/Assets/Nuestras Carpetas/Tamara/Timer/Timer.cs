using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{

    [SerializeField]
    private int minute;

    [SerializeField]
    private int seconds;

    private int m, s;

    public bool timerstop;

    [SerializeField]
    private TMP_Text timerText;


    void Start()
    {
        startTimer();
        timerstop = false;
    }

    public void startTimer()
    {
        m = 3;
        s = 0;
        writeTimer(m, s);
    }
    public void stopTimer()
    {
        timerstop = true;
    }
    private void updateTimer()
    {

        s--;
        if (s < 0)
        {

            if (m == 0)
            {
                //end game
                return;
            }
            else
            {
                m--;
                s = 59;
            }

        }
        writeTimer(m, s);
    }
    private void writeTimer(int m, int s)
    {
        if (s < 10)
        {
            timerText.text = m.ToString() + " :0" + s.ToString();
        }
        else
        {
            timerText.text = m.ToString() + " :" + s.ToString();
        }
    }
    // Update is called once per frame
    void Update()
    {

        if (!timerstop) {
            updateTimer();
        }
    }
}

