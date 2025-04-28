using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public bool isListOpen = false;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
            Destroy(gameObject);
       
    }
}
