using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTime : MonoBehaviour
{
    private string time;

    void Update()
    {

        UIManager.Instance.UpdateTime(Time.time);
    }

}
