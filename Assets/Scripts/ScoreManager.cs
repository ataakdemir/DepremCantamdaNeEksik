using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public float totalScore = 0f;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddScore(float score)
    {
        totalScore += score;
        Debug.Log("Puan eklendi! Toplam puan: " + totalScore);
    }
    public void ResetScore()
    {
        totalScore = 0f;
        Debug.Log("Skor sýfýrlandý!");
    }

}
