using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinalSceneScript : MonoBehaviour
{

    public GameObject items, description, final;
    public GameObject colleges;
    public TextMesh tex;
    private int count=0;
    // Start is called before the first frame update
    void Start()
    {   
        StartCoroutine(timer());
    }

    // Update is called once per frame
    void Update()
    {
        if(count==7){
            colleges.SetActive(false);
            tex.text="His path enlightened all.\nThe path of one for all.";
            final.SetActive(true);
        }else if(count==12){
            tex.text="We will remember your motives. \nWe will remember your dreams.\nWe will remember you";
        }else if(count==18){
            tex.text="";
            items.SetActive(true);
            description.SetActive(true);
            final.SetActive(false);
        }
    }

    IEnumerator timer(){
        while(true){
            count++;
            yield return new WaitForSeconds(1f);
        }
    }
}
