using Mono.Data.Sqlite;
using System.Data;
using UnityEngine;
using System.Collections.Generic;
public class DBManager : MonoBehaviour
{
    //DB
    IDbConnection dbConnection;
    //Ingredients
    public List<int> id_ingredients = new List<int>();
    public List<string> name_ingredients = new List<string>();
    //Potions
    public List<int> id_potions = new List<int>();
    public List<string> name_potions = new List<string>();
    private void Awake()
    {
        OpenDatabase();
        IngredientList();
        PotionsList();
    }
    //DB
    private void OpenDatabase()
    {
        string dbUri = "URI=file:alchENTImist.db";
        dbConnection = new SqliteConnection(dbUri);
        dbConnection.Open();
    }
    //Ingredients
    void IngredientList()
    {
        string ingredientsQuery = "SELECT* FROM ingredients";

        IDbCommand cmd = dbConnection.CreateCommand();
        cmd.CommandText = ingredientsQuery;

        IDataReader dataReader = cmd.ExecuteReader();

        while (dataReader.Read())
        {
            id_ingredients.Add(dataReader.GetInt32(0));
            name_ingredients.Add(dataReader.GetString(1));
            //for (int i = 0; i < id_ingredients.Count; i++)
            //{
            //    Debug.Log(id_ingredients[i]);
            //    Debug.Log(name_ingredients[i]);
            //}
        }
    }
    public List<int> GetIngredientsIdList()
    {
        return id_ingredients;
    }
    public List<string> GetIngredientsNameList()
    {
        return name_ingredients;
    }
    //Potions
    void PotionsList()
    {
        string ingredientsQuery = "SELECT* FROM potions";

        IDbCommand cmd = dbConnection.CreateCommand();
        cmd.CommandText = ingredientsQuery;

        IDataReader dataReader = cmd.ExecuteReader();

        while (dataReader.Read())
        {
            id_potions.Add(dataReader.GetInt32(0));
            name_potions.Add(dataReader.GetString(1));
        }
        //for (int i = 0; i < id_potions.Count; i++)
        //{
        //    Debug.Log(id_potions[i]);
        //    Debug.Log(name_potions[i]);
        //}
    }
    public List<int> GetPotionIdList()
    {
        return id_potions;
    }
    public List<string> GetPotionsNameList()
    {
        return name_potions;
    }
}