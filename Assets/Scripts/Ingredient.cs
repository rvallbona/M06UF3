using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Ingredient : MonoBehaviour
{
    public GameObject ingredient;
    DBManager dbManager;
    List<string> nameIngredientsList;
    List<int> idIngredientsList;

    List<Ingredient> ingredients;
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

            TMPro.TextMeshProUGUI ingredientName = newIngredient.GetComponent<TMPro.TextMeshProUGUI>();
            ingredientFormat ingre = new ingredientFormat();
            ingre.id_ingredient = idIngredientsList[i];
            ingre.name_ingredient = nameIngredientsList[i];
            Debug.Log(ingre);
            ingredientName.text = ingre.name_ingredient;
        }
    }
}
