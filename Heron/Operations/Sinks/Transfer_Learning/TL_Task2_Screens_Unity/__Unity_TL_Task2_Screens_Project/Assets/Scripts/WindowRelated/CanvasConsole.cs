using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasConsole : MonoBehaviour
{

    public Text consoleText;
    private string consoleString;

    void OnEnable()
    {
        Application.logMessageReceived += HandleLog;
    }

    void OnDisable()
    {
        Application.logMessageReceived -= HandleLog;
    }

    void HandleLog(string message, string stackTrace, LogType type)
    {
        consoleString = consoleString + "\n" + message;
        consoleText.text = consoleString;
    }

}
