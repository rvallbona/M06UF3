using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CraftingManager : MonoBehaviour
{
    private Item currentItem;
    public Image cursor;

    public Slot[] craftingSlots;
    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            if (currentItem != null)
            {
                cursor.gameObject.SetActive(false);
                Slot nearestSlot = null;
                float shortestDistance = float.MaxValue;

                foreach (Slot slot in craftingSlots)
                {
                    float dist = Vector2.Distance(Input.mousePosition, slot.transform.position);
                    if (dist < shortestDistance)
                    {
                        shortestDistance = dist;
                        nearestSlot = slot;
                    }
                }
                nearestSlot.gameObject.SetActive(true);
                nearestSlot.GetComponent<Image>().sprite = currentItem.GetComponent<Sprite>();
                nearestSlot.item = currentItem;
                currentItem = null;
            }
        }
    }
    public void OnMouseDownItem(Item item)
    {
        if (currentItem == null)
        {
            currentItem = item;
            cursor.gameObject.SetActive(true);
            cursor.sprite = currentItem.GetComponent<Image>().sprite;
        }
    }
}
