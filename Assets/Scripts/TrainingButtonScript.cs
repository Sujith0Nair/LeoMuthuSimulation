using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrainingButtonScript : MonoBehaviour
{

    public GameObject gui, LoadingScreen;
    public AudioSource menuLoad, menuSelect;
    public Slider Mainslider, loadingSlider;
    void Start()
    {
        Mainslider=GameObject.Find("SliderFirst").GetComponent<Slider>();
       // gui=GameObject.Find("GUI").GetComponent<GameObject>(); 
   }

    public void RayEnter(){
        Debug.Log("In call functon");
        menuLoad.Play();
        Mainslider.value=100;
        
    }

    public void RayExit(){
        Debug.Log("Out of call functon");
        Mainslider.value=0;
    }

    public void RayCommand(){
        menuSelect.Play();
        gui.SetActive(false);
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
       // StartCoroutine(LoadAsynchronously(01));       
    }

    IEnumerator LoadAsynchronously(int sceneIndex){
        AsyncOperation operation= UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneIndex);
        LoadingScreen.SetActive(true);
        while(!operation.isDone){
            float progress = Mathf.Clamp01(operation.progress/.9f);
            loadingSlider.value=progress;    
            yield return null;
        }        
    }
}
