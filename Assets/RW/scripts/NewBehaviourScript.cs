using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NewBehaviourScript : MonoBehaviour
{
    public Animator startButton;
    public Animator settingsButton
    public void StartGame()
    public void OpenSettings() }
    {
        startButton.SetBool("isHidden", true);
        settingsButton.SetBool("isHidden", true);
    }
    {
        SceneManager.LoadScene("RocketMouse");
    }
}
