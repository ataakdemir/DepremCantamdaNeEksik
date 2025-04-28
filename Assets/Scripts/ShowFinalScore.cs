using TMPro;
using UnityEngine;

public class ShowFinalScore : MonoBehaviour
{
    public TMP_Text scoreText;

    void Start()
    {
        float score = ScoreManager.instance.totalScore;
        scoreText.text = "Al��veri� listende yer alan 8 �r�nden " + score.ToString("F0") + " tanesini ald�n.";
    }
}
