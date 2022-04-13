using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    static public UIManager Instance;
    public GameObject pnlGameStart;

    private void Awake()
    {
        if (!Instance)
            Instance = this;
    }



    public void EventPlayAgain()
    {
        Application.LoadLevel(0);
    }
    public void StartEvent()
    {
        pnlGameStart.SetActive(false);
        GameManager.Instance.mGameState = GameState.Playing;

    }
}
