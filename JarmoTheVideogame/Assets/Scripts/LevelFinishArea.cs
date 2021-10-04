using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelFinishArea : MonoBehaviour
{
    [SerializeField] private List<string> TriggerTags = new List<string>();

    private LevelTime levelTimeScript;

    private void Start()
    {
        levelTimeScript = FindObjectOfType<LevelTime>();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (TriggerTags.Contains(collision.gameObject.tag))
        {
            levelTimeScript.updateTime = false;
            GameManager.Instance.UpdateMoneyAmount(50);
        }
    }
}
