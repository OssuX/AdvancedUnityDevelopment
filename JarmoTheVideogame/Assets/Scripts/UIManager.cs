using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    [SerializeField] private GameObject MainMenuScreen;

    private void Start()
    {
        ToggleUIScreen(true);
    }

    public void ToggleUIScreen(bool value)
    {
        MainMenuScreen.SetActive(value);
    }

    public void RefreshUI()
    {

    }
}