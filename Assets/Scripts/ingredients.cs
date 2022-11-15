using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ingredients : MonoBehaviour
{
    public GameObject ingredient;
    [SerializeField]
    private Sprite[] ingredientSprite;
    void Start()
    {
        for (int i = 0; i < 2; i++)
        {
            GameObject newIngredient = Instantiate(ingredient, transform.position, transform.rotation) as GameObject;
            newIngredient.transform.SetParent(GameObject.FindGameObjectWithTag("ListaIngredientes").transform, false);
            ingredient.GetComponent<Image>().sprite = ingredientSprite[i];
        }
    }
}
