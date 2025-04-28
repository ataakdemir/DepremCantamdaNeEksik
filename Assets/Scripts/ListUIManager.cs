using UnityEngine;

public class ListUIManager : MonoBehaviour
{
    public GameObject list;

    private bool isOpen = false;

    void Start()
    {
        list.SetActive(false);
        GameManager.instance.isListOpen = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            isOpen = !isOpen;
            list.SetActive(isOpen);
            GameManager.instance.isListOpen = isOpen;
        }
    }
}
