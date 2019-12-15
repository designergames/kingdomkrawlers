﻿using System.Collections;
using System.Collections.Generic;
using ManningsLootSystem;
using UnityEngine;
using UnityEngine.UI;

public class PauseTransition : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject hud;
    public bool escapePress = false;


     

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            escapePress = !escapePress;
        }

        if (escapePress == false)
        {
            hud.SetActive(true);
            pauseMenu.SetActive(false);
            Time.timeScale = 1;
        }

        if (escapePress == true)
        {
            hud.SetActive(false);
            pauseMenu.SetActive(true);
            Time.timeScale = 0;
            InventoryController.Instance.ShowInventory(false);
        }
    }
}
