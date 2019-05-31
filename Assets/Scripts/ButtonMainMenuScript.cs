using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonMainMenuScript : MonoBehaviour
{
    public GameObject about;
    public Image fg;
    public AudioSource menuSelection;
    LoadingScreenScript loadManager;

    public TextMesh textInfo;
    
    void Start()
    {
        fg= GetComponent<Image>();
        textInfo= GameObject.Find("T").GetComponent<TextMesh>();
        menuSelection=GameObject.Find("SelectSound").GetComponent<AudioSource>();
    }

    public void RayEnter(){
        menuSelection.Play();
       if(this.gameObject.name=="TimelineControl"){
           textInfo.text="Know the history of\nMJF Lion Leo Muthu";
        }else if(this.gameObject.name=="QuizControl"){
            textInfo.text="How well do you know about\nMJF Lion Leo Muthu";
        }else if(this.gameObject.name=="AboutControl"){
            textInfo.text="About the developer";
            about.SetActive(true);
        }
    }

    public void RayExit(){
        textInfo.text="";
        about.SetActive(false);
    }

    public void RayCommand(){
        if(this.gameObject.name=="TimelineControl"){
            SceneManager.LoadScene(2);
        }else if(this.gameObject.name=="AboutControl"){
            about.SetActive(true);  
        }
    }
}
