using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneWin : MonoBehaviour
{
    public void changeScene()
    {
        Application.LoadLevel("MainScene");
    }
    public void ExitGame()
    {
        Application.LoadLevel("Home");
    }
}
