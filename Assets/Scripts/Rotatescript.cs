using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotatescript : MonoBehaviour
{
    public TextMesh t;
    public Transform[] pos;

    GameObject player;

    void Start(){
        player=GameObject.FindWithTag("Player").GetComponent<GameObject>();
    }
    void Update()
    {
        transform.Rotate(Vector3.up, Time.deltaTime*50);
    }

    public void RayEnter(){
        Debug.Log("In call functon");
        t.text="Move Next";
    }

    public void RayExit(){
        t.text="";
    }
    public void RayCommand(){
        if(this.gameObject.name=="tel01"){
            player.transform.position=pos[0].position;
        }else if(this.gameObject.name=="tel02"){
            player.transform.position=pos[1].position;
        }else if(this.gameObject.name=="tel03"){
            player.transform.position=pos[2].position;
        }else if(this.gameObject.name=="tel04"){
            player.transform.position=pos[03].position;
        }else if(this.gameObject.name=="tel05"){
            player.transform.position=pos[04].position;
        }
    }
}
