using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GameManager : Singleton<GameManager>
{
    private GameObject playerReference;
    private int money = 5;
   
    
    private void Start()
    {
        UIManager.Instance.UpdateMoney(money);
    }

    public void UpdateMoneyAmount(int amount)
    {
        UIManager.Instance.UpdateMoney(amount);
    }

    

    public GameObject player
    {
        get
        {
            return playerReference;
        }
        set
        {
            playerReference = value;
            Debug.Log("Player added to gamemanager", value);
        }
    }
}
