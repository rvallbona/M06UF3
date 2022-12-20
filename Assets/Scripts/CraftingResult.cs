using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static Potions;

public class CraftingResult : MonoBehaviour
{
    public GameObject potion;
    DBManager dbManager;
    List<string> namePotionsList;
    List<int> idPotionsList;

    [SerializeField] Slot slot;
    private void Start()
    {
        dbManager = GameObject.FindGameObjectWithTag("dbManager").GetComponent<DBManager>();
        idPotionsList = dbManager.GetPotionIdList();
        namePotionsList = dbManager.GetPotionsNameList();
    }
    private void Update()
    {
        //for (int i = 0; i < idPotionsList.Count; i++)
        //{
        //    if (slot.id_potion_created == idPotionsList[i])
        //    {
        //        GameObject newPotion = Instantiate(potion, transform.position, transform.rotation) as GameObject;
        //        newPotion.transform.SetParent(GameObject.FindGameObjectWithTag("ListaResult").transform, false);
        //        TextMeshProUGUI potiontName = newPotion.GetComponent<TextMeshProUGUI>();
        //        potionFormat poti = new potionFormat();
        //        poti.id_potion = idPotionsList[i];
        //        poti.name_potion = namePotionsList[i];
        //        potiontName.text = poti.id_potion + "." + poti.name_potion;
        //    }
        //    //Debug.Log(idPotionsList[i] + namePotionsList[i]);
        //}
    }
}
