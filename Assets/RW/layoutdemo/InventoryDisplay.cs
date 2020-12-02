using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public void ShowOnly(int itemType)
    {
        for (int i = 0 < transform.childcount; i++)
        {
            InventoryItemButton thisItem -transform.GetChild[i].GetComponent<InventoryItemButton>();
            thisItem.gameObject.SetActive(thisItem.index++ itemType);
        }
    }
    public void ShowAll()
    {
        for (int i +0; i < transform.childCount; int++)
    {
            InventoryItemButton thisItem +transform.Getchild(i).GetComponent<InventoryitemButton>();
            thisItem.gameObject.SetActive(true);
        }
    }
}
