using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using System;

public class Slot : MonoBehaviour, IDropHandler
{
    GameObject slotedIngredient;
    TextMeshProUGUI ingredient;
    public string[] ingredients_ids;
    public string idIngredient;
    public List<string> idsIngredientsList;
    DBManager dbManager;
    private int indexPotionIngredients;
    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            slotedIngredient = eventData.pointerDrag;
            eventData.pointerDrag.GetComponent<RectTransform>().position = this.GetComponent<RectTransform>().position;
            slotedIngredient.SetActive(false);
            ingredient = slotedIngredient.GetComponent<TextMeshProUGUI>();
            ingredients_ids = ingredient.text.ToString().Split(".");
            idIngredient = ingredients_ids[0];
            Debug.Log(idIngredient);
            idsIngredientsList.Add(idIngredient);
            indexPotionIngredients += 1;
        }
        if (indexPotionIngredients == 3)
        {
            dbManager.ConfirmationIngredientsPotions(idsIngredientsList);
        }
    }
}
