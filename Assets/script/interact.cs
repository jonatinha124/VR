using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class interact : MonoBehaviour
{
    public Button StartButtom;
    public Image circleProgress;
    public float totalTime = 3;
    private bool gvrStatus;
    private float gvrTimer;
    public UnityEvent gvrClick;
   
    void Update()
    {
        if (gvrStatus == true)
        {
            gvrTimer += Time.deltaTime;
            circleProgress.fillAmount = gvrTimer / totalTime;

            if(gvrTimer > totalTime)
            {
                gvrClick.Invoke();
            }
        }
        else
        {
            gvrTimer = 0;
            circleProgress.fillAmount = 0;
        }
    }

    public void gvrOnButton()
    {
        gvrStatus = true;
    }

    public void gvrOffButton()
    {
        gvrStatus = false;
    }
}
