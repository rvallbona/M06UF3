using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
public class Slot : MonoBehaviour, IDropHandler
{
    GameObject slotedIngredient;
    TextMeshProUGUI ingredient;
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Sloted");
        if (eventData.pointerDrag != null)
        {
            slotedIngredient = eventData.pointerDrag;
            eventData.pointerDrag.GetComponent<RectTransform>().position = this.GetComponent<RectTransform>().position;
            ingredient = slotedIngredient.GetComponent<TextMeshProUGUI>();
            int.TryParse(ingredient.ToString(), out int id);
        }
    }
}
