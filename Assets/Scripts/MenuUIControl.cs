using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIControl : MonoBehaviour
{
    [SerializeField] TMP_InputField playerName;
    public void setPlayerName(string name)
    {
        UIManager.Instance.playerName = name;
    }

    public void StartNew()
    {
        if(UIManager.Instance.playerName != null)
        {
            if (!playerName.Equals(UIManager.Instance.playerName))
            {
                setPlayerName(playerName.text);
            }
        }
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        #if UNITY_EDITOR
                EditorApplication.ExitPlaymode();
        #else
                Application.Quit(); // original code to quit Unity player
        #endif
    }
}
