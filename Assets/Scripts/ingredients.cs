using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ingredients : MonoBehaviour
{
    public GameObject ingredient;
    DBManager dbManager;
    List<string> ingredientsList;
    void Start()
    {
        dbManager = GameObject.FindGameObjectWithTag("dbManager").GetComponent<DBManager>();
        ingredientsList = dbManager.GetIngredientsNameList();
        for (int i = 0; i < ingredientsList.Count; i++)
        {
            GameObject newIngredient = Instantiate(ingredient, transform.position, transform.rotation) as GameObject;
            newIngredient.transform.SetParent(GameObject.FindGameObjectWithTag("ListaIngredientes").transform, false);

            TMPro.TextMeshProUGUI ingredientName = newIngredient.GetComponent<TMPro.TextMeshProUGUI>();
            ingredientName.text = ingredientsList[i];Debug.Log(ingredientsList[i]);
        }
    }
}
