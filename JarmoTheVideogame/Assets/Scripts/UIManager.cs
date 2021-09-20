using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class UIManager : Singleton<UIManager>
{
    [SerializeField] private GameObject MainMenuScreen;
    [SerializeField] private GameObject LoadSceneScreen;
    [SerializeField] private GameObject SettingsScreen;
    [SerializeField] private GameObject gameUI;

    [SerializeField] public TMP_Text TimeCounter;

    private string time = "testigang";

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

    public void UpdateTime(float time)
    {

        TimeSpan t = TimeSpan.FromSeconds(time);
        string timeToText = string.Format("{1:D2}.{2:D2}.{3:D3}",
            t.Hours,
            t.Minutes,
            t.Seconds,
            t.Milliseconds);
        TimeCounter.text = timeToText;
    }

    public void TurnOffMenuUI() //load game
    {
        MainMenuScreen.SetActive(false);
        LoadSceneScreen.SetActive(false);
        SettingsScreen.SetActive(false);
        gameUI.SetActive(true);
    }
}
