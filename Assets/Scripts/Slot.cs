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
    [HideInInspector] public string[] ingredients_ids;
    [HideInInspector] public string idIngredient;
    [HideInInspector] public List<string> idsIngredientsList;
    [SerializeField] DBManager dbManager;
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
            idsIngredientsList.Add(idIngredient);
            indexPotionIngredients += 1;
        }
        if (indexPotionIngredients == 3)
        {
            dbManager.CheckRecipe(idsIngredientsList);
        }
    }
}
