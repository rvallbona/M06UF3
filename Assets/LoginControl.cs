using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class LoginControl : MonoBehaviour
{
    public TMP_InputField usernameInput;
    private string user_name;
    DBManager dbManager;
    [SerializeField]MainMenuManager menuManager;
    List<string> namePotionsList;

    void Start()
    {
        user_name = usernameInput.text;
        dbManager = GetComponent<DBManager>();
        dbManager = GameObject.FindGameObjectWithTag("dbManager").GetComponent<DBManager>();
    }
    void Update()
    {
        user_name = usernameInput.text;
        namePotionsList = dbManager.GetLoginNameList();
        for (int i = 0; i < namePotionsList.Count; i++)
        {
            if (namePotionsList[i] == user_name)
            {
                menuManager.Logged();
                Destroy(gameObject);
            }
        }
    }
    public void SaveUsername(string newName)
    {

    }
}