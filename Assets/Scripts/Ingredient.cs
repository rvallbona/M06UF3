using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Ingredient : MonoBehaviour
{
    public GameObject ingredient;
    DBManager dbManager;
    List<string> nameIngredientsList;
    List<int> idIngredientsList;
    List<ingredientFormat> ingredients;
    public struct ingredientFormat
    {
        public int id_ingredient;
        public string name_ingredient;
    }
    void Start()
    {
        dbManager = GameObject.FindGameObjectWithTag("dbManager").GetComponent<DBManager>();
        idIngredientsList = dbManager.GetIngredientsIdList();
        nameIngredientsList = dbManager.GetIngredientsNameList();
        for (int i = 0; i < nameIngredientsList.Count; i++)
        {
            GameObject newIngredient = Instantiate(ingredient, transform.position, transform.rotation) as GameObject;
            newIngredient.transform.SetParent(GameObject.FindGameObjectWithTag("ListaIngredientes").transform, false);
            TextMeshProUGUI ingredientName = newIngredient.GetComponent<TextMeshProUGUI>();
            ingredientFormat ingre = new ingredientFormat();
            ingre.id_ingredient = idIngredientsList[i];
            ingre.name_ingredient = nameIngredientsList[i];
            ingredientName.text = ingre.id_ingredient + "." + ingre.name_ingredient;
        }
    }
}
