using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTime : MonoBehaviour
{
    public float timeValue;
    public bool updateTime = true;



    private float nextTimeToFlash = 0f;

    void Update()
    {
        if(updateTime)
        {
            timeValue = Time.time;

            if(Time.time >= nextTimeToFlash)
            {
                UIManager.Instance.FlashText();
                nextTimeToFlash = Time.time + 1f / 1f;
            }
        }

        UIManager.Instance.UpdateTime(timeValue);
    }

    
}
