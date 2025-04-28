using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
 
    public void PlayAgain()
    {
        if (ScoreManager.instance != null)
            ScoreManager.instance.ResetScore();
        SceneManager.LoadScene("SampleScene");
    }
    
    public void Quit()
    {
        Application.Quit();
    }
}
