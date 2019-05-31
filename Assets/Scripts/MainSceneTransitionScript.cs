using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MainSceneTransitionScript : MonoBehaviour
{

    public Transform[] transforms;
    public GameObject player;
    public int count=0, val=0;
    void Start()
    {
        StartCoroutine(timer());
    }

    void Update()
    {
        if(count==10){
            val++;
            Debug.Log(val);
            count=0;
            Debug.Log("Inside count");
            switch(val){
            case 1: Debug.Log("Position case 1 taken!");
                    Debug.Log(transforms[0].transform.position);
                    player.transform.position = transforms[0].position;
                    break;
            case 2: Debug.Log("Position case 2 taken!");
                    player.transform.position=transforms[1].position;
                    break;
            case 3: Debug.Log("Position case 3 taken!");
                    player.transform.position=transforms[2].position;
                    break;
            case 4: Debug.Log("Position case 4 taken!");
                    player.transform.position=transforms[3].position;
                    break;
            case 5: player.transform.position=transforms[4].position;
                    break;
            case 6: SceneManager.LoadSceneAsync("FinalScene");
                    break;                    
            }  
        }              
    }

    IEnumerator timer(){
        while(true){
            count++;
            yield return new WaitForSeconds(1f);            
        }        
    }
}
