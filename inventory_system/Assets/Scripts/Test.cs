﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    /*
    Van een InventorySystem verwacht je dat hij bepaalde logica heeft
    zoals het toevoegen van items
    en dat je items er weer uit kunt halen
    Dat je het aantal items kunt opvragen van een bepaald type, etc.
    */
	void Start ()
	{
	    TestBad();
	    TestGood();
	}

    void TestBad()
    {
        var inventory = new InventoryBad();
        var item = inventory.GetItem("rock");
        Debug.Log(item);
    }

    void TestGood()
    {
        var inventory = new InventoryGood();

        // dit vullen kan ook vanuit een andere Class
        // of vanuit een extern bestand (bijvoorbeeld JSON)
        inventory.AddItem("rock", "rock instance");
        inventory.AddItem("spoon", "spoon instance");
        inventory.AddItem("chair", "chair instance");
        inventory.AddItem("table", "table instance");
        inventory.AddItem("cup", "cup instance");

        var item = inventory.GetItem("rock");
        Debug.Log(item);
    }
}
