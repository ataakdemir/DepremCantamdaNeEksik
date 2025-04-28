using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartGame : MonoBehaviour
{
    public void PlayGame()
    {
        if (ScoreManager.instance != null)
            ScoreManager.instance.ResetScore();
        SceneManager.LoadScene("Cutscene");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
