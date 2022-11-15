using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IDragHandler
{
    public void OnDrag(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;
        Item item = dropped.GetComponent<Item>();
        item.parentAfterDrag = transform;
    }
}
