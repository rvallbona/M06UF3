using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Potions : MonoBehaviour
{
    public GameObject potion;
    DBManager dbManager;
    List<string> namePotionsList;
    List<int> idPotionsList;
    List<potionFormat> potions;
    potionFormat poti = new potionFormat();
    [SerializeField] Slot slot;
    private int id_potionToSpawn;
    public struct potionFormat
    {
        public int id_potion;
        public string name_potion;
    }
    void Update()
    {
        id_potionToSpawn = slot.id_potion_created;
        dbManager.PotionsList(id_potionToSpawn);
        #region antiguo
        dbManager = GameObject.FindGameObjectWithTag("dbManager").GetComponent<DBManager>();
        idPotionsList = dbManager.GetPotionIdList();
        namePotionsList = dbManager.GetPotionsNameList();
        for (int i = 0; i < namePotionsList.Count; i++)
        {
            GameObject newPotion = Instantiate(potion, transform.position, transform.rotation) as GameObject;
            newPotion.transform.SetParent(GameObject.FindGameObjectWithTag("ListaPociones").transform, false);
            newPotion.SetActive(false);
            TextMeshProUGUI potiontName = newPotion.GetComponent<TextMeshProUGUI>();
            poti.id_potion = idPotionsList[i];
            poti.name_potion = namePotionsList[i];
            potiontName.text = poti.id_potion + "." + poti.name_potion;
        }
        #endregion

    }
}