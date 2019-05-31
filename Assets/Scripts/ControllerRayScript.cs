using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllerRayScript : MonoBehaviour
{

    public GameObject go, empty;

    void Start()
    {
        empty = new GameObject();
		go = empty;    
    }
    void Update()
    {
        RaycastHit hit;
        transform.rotation=OVRInput.GetLocalControllerRotation(OVRInput.Controller.RTrackedRemote);
        if(Physics.Raycast(transform.position,transform.forward,out hit)){
            if(hit.collider!=null){
                if(go!=hit.collider.gameObject){    
                    go.transform.SendMessage("RayExit");
                    go=hit.transform.gameObject;
                    go.transform.SendMessage("RayEnter");
                    Debug.Log("Ray Entered!");
                }
                if(OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger)){
                    go.transform.SendMessage("RayCommand");
                }
                if(OVRInput.GetDown(OVRInput.Button.One)){
					
				}
				if(OVRInput.GetDown(OVRInput.Button.Two)){
					SceneManager.LoadSceneAsync(2);
				}
				if(OVRInput.GetDown(OVRInput.Touch.One)){
					
				}
            }
        }else
        {
            if(go!=null){
				go.transform.SendMessage("RayExit");
                Debug.Log("Ray Exit!");	
				go=empty;
			}	
        }
    }
}
