﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    public AudioSource buttonSound;

    [SerializeField]
    private string sceneToLoad;


    public void ButtonClick()
    {
        StartCoroutine(AfterButtonClick());
        buttonSound.Play(0);
    }

    public IEnumerator AfterButtonClick()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene(sceneToLoad);
    }
}
