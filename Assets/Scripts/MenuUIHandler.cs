using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

#if UNITY_EDITOR
using UnityEditor;
#endif
// Sets the script to be executed later than all default scripts
// This is helpful for UI, since other things may need to be initialized before setting the UI
[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public Text NameText;
    public Button StartButton;
    
    public void NewNameEntered(Text NameText)
    {
        // add code here to handle when a name is entered
        MainManager.Instance.NameText = NameText;
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }
    public void ExitSession()
    {
#if UNITY_EDITOR
                EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }
}
