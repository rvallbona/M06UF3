using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IDropHandler
{
    GameObject slotedIngredient;
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Sloted");
        if (eventData.pointerDrag != null)
        {
            slotedIngredient = eventData.pointerDrag;
            eventData.pointerDrag.GetComponent<RectTransform>().position = this.GetComponent<RectTransform>().position;
            Ingredient ingredient = slotedIngredient.GetComponent<Ingredient>();
        }
    }
}
