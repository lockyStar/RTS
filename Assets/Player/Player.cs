﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    //ADDED
    public string username;
    public bool human;
    public HUD hud;
    public WorldObject SelectedObject { get; set; }
    //ADDED
    // Use this for initialization
    void Start () {
        hud = GetComponentInChildren<HUD>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
