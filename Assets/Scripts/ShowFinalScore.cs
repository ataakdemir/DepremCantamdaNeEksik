using TMPro;
using UnityEngine;

public class ShowFinalScore : MonoBehaviour
{
    public TMP_Text scoreText;

    void Start()
    {
        float score = ScoreManager.instance.totalScore;
        scoreText.text = "Alýþveriþ listende yer alan 8 üründen " + score.ToString("F0") + " tanesini aldýn.";
    }
}
