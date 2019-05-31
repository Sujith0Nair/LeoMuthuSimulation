﻿using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScreenScript : MonoBehaviour
{

    public GameObject LoadingScreen;
    public Slider slider;
    
    public void LoadLevel(int sceneIndex){
        StartCoroutine(LoadAsynchronously(sceneIndex));
        Debug.Log("Scene to be loaded: "+ sceneIndex);
    }

    IEnumerator LoadAsynchronously(int sceneIndex){
        AsyncOperation operation= SceneManager.LoadSceneAsync(sceneIndex);
        LoadingScreen.SetActive(true);
        while(!operation.isDone){
            float progress = Mathf.Clamp01(operation.progress/.9f);
            slider.value=progress;    
            yield return null;
        }        
    }
}
