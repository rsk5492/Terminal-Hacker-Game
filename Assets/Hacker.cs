﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

	// Use this for initialization
	void Start () {
        ShowMainMenu();
    }

    void ShowMainMenu() {
        Terminal.ClearScreen();
        string greeting = "Hello Hacker!!";
        Terminal.WriteLine(greeting);
        Terminal.WriteLine("What would you like to hack into?\n");
        Terminal.WriteLine("Press 1 for the local library");
        Terminal.WriteLine("Press 2 for the police station");
        Terminal.WriteLine("Press 3 for NASA \n");
        Terminal.WriteLine("Enter your selection: ");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}