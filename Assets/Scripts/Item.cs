using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Item : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [HideInInspector] public Transform parentAfterDrag;
    //TMPro.TextMeshProUGUI ingredientText;
    private RectTransform rectTransform;
    public void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        //GameObject ingredient = GameObject.FindGameObjectWithTag("Ingredient");
        //ingredientText = ingredient.GetComponent<TMPro.TextMeshProUGUI>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Drag");
    }
    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Dragging");
        rectTransform.anchoredPosition += eventData.delta;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("EndDrag");
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
    }
}
