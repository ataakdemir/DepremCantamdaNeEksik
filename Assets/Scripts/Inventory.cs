using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory instance;

    public int maxCapacity = 10;
    public GameObject inventoryFullWarning;
    private void Awake()
    {
        instance = this;
    }

    public List<Item> items = new List<Item>();

    private void Update()
    {
        if (items.Count>= maxCapacity)
        {
            inventoryFullWarning.SetActive(true);
        }
    }
    public void AddItem(Item newItem)
    {
        if (items.Count >= maxCapacity)
        {
            Debug.Log("Envanter dolu! Yeni eşya alınamaz.");
            return;
        }

        items.Add(newItem);
        Debug.Log(newItem.itemName + " eklendi!");
    }
}
