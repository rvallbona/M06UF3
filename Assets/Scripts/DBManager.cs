using Mono.Data.Sqlite;
using System.Data;
using UnityEngine;
using System.Collections.Generic;
public class DBManager : MonoBehaviour
{
    //DB
    IDbConnection dbConnection;
    //Ingredients
    public List<string> name_ingredients = new List<string>();
    private void Start()
    {
        OpenDatabase();
        Ingredients();
    }
    private void OpenDatabase()
    {
        string dbUri = "URI=file:alchENTImist.db";
        dbConnection = new SqliteConnection(dbUri);
        dbConnection.Open();
    }
    void Ingredients()
    {
        string ingredientsQuery = "SELECT* FROM ingredients";

        IDbCommand cmd = dbConnection.CreateCommand();
        cmd.CommandText = ingredientsQuery;

        IDataReader dataReader = cmd.ExecuteReader();

        while (dataReader.Read())
        {
            name_ingredients.Add(dataReader.GetString(1));
            Debug.Log(name_ingredients);
        }
    }
}