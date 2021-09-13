using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    [SerializeField] private GameObject MainMenuScreen;
    [SerializeField] private GameObject LoadSceneScreen;
    [SerializeField] private GameObject SettingsScreen;

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

    public void TurnOffMenuUI()
    {
        MainMenuScreen.SetActive(false);
        LoadSceneScreen.SetActive(false);
        SettingsScreen.SetActive(false);
    }
}
