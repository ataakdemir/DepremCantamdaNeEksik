using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    public Item item;
    public float itemScore;

    public void Pickup()
    {
        if (Inventory.instance.items.Count >= Inventory.instance.maxCapacity)
        {
            Debug.Log("Envanter dolu, eþya alýnamadý.");
            return;
        }

        Inventory.instance.AddItem(item);

        if (ScoreManager.instance != null)
        {
            ScoreManager.instance.AddScore(itemScore);
        }

        Destroy(gameObject);
    }
}
