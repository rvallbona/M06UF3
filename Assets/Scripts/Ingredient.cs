using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Ingredient : MonoBehaviour
{
    public GameObject ingredient;
    DBManager dbManager;
    List<string> nameIngredientsList;
    List<int> idIngredientsList;
    int id_ingredient;
    string name_ingredient;
    List<Ingredient> ingredients;
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
            ingredientName.text = idIngredientsList[i] + nameIngredientsList[i];
        }
    }
    public void SetIngredient(int id, string name)
    {
        id_ingredient = id;
        name_ingredient = name;
    }
}
