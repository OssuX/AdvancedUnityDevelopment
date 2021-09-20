using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    private GameObject playerReference;

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
