using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RestartGame : MonoBehaviour
{
    public void StartAgain()
    {
        if (ScoreManager.instance != null)
            ScoreManager.instance.ResetScore();
        SceneManager.LoadScene("SampleScene");
    } 

    public void StartMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }

}
