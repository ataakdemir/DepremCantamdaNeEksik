using UnityEngine;

public class ItemPickupSystem : MonoBehaviour
{
    public float pickupRange = 3f;
    public LayerMask itemLayer;

    private Outline currentOutline;

    void Update()
    {
        Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        RaycastHit hit;

        // Raycast ile item’a bakýyor muyuz?
        if (Physics.Raycast(ray, out hit, pickupRange, itemLayer))
        {
            Outline outline = hit.collider.GetComponent<Outline>();

            if (outline != null)
            {
                if (currentOutline != null && currentOutline != outline)
                {
                    currentOutline.enabled = false;
                }

                outline.enabled = true;
                currentOutline = outline;
            }
        }
        else
        {
            // Hiçbir item’a bakýlmýyorsa aktif outline'ý kapat
            if (currentOutline != null)
            {
                currentOutline.enabled = false;
                currentOutline = null;
            }
        }

        // Sol týk ile item toplama
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (Physics.Raycast(ray, out hit, pickupRange, itemLayer))
            {
                PickUpItem pickup = hit.collider.GetComponent<PickUpItem>();
                if (pickup != null)
                {
                    pickup.Pickup();
                }
            }
        }
    }
}
