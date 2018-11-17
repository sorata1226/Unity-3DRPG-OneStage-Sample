﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

    List<int> itemList = new List<int>();


    public void AddItem(Item.ItemType type)
    {
        //print((int)type);
        itemList.Add((int)type);

    }

    public bool HasItem()
    {
        print(itemList.Count);
        if (itemList.Count >= 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
