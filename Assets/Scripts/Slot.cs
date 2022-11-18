using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IDropHandler
{
    //public Item item;
    //public int slotIndex;
    GameObject slotedIngredient;
    TMPro.TextMeshProUGUI ingredientName;
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Sloted");
        if (eventData.pointerDrag != null)
        {
            slotedIngredient = eventData.pointerDrag;
            eventData.pointerDrag.GetComponent<RectTransform>().position = this.GetComponent<RectTransform>().position;
            ingredientName = slotedIngredient.GetComponent<TMPro.TextMeshProUGUI>();
            Debug.Log(int.Parse(ingredientName.text)); 
        }
    }
}
