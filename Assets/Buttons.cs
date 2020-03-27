using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
 public void ChangeDisplayMode()
    {
        Screen.fullScreen = !Screen.fullScreen;
    }
    public void ExitApp()
    {
        Application.Quit();
    }
}
