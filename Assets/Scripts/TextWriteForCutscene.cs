using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TextWriterForCutscene : MonoBehaviour
{
    public TMP_Text textComponent; 
    public string[] sentences; 
    public float typingSpeed = 0.05f; 

    private int index = 0; 
    private bool isTyping = false;

    void Start()
    {
        textComponent.text = "";
        StartCoroutine(TypeLine());
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isTyping)
            {
                StopAllCoroutines();
                textComponent.text = sentences[index];
                isTyping = false;
            }
            else
            {
                index++;
                if (index < sentences.Length)
                {
                    textComponent.text = "";
                    StartCoroutine(TypeLine());
                }
                else
                {
                    Debug.Log("Cutscene bitti");
                    SceneManager.LoadScene("SampleScene");

                }
            }
        }
    }

    IEnumerator TypeLine()
    {
        isTyping = true;
        foreach (char letter in sentences[index].ToCharArray())
        {
            textComponent.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
        isTyping = false;
    }
}
