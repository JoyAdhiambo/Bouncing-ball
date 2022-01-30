using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followplayer : MonoBehaviour
{
    GameObject player;
    public float moveSpeed;
    public  Vector3 offset;
    public float Towardsspeed;
    [HideInInspector]
   public bool move;
    void Awake()
    {
        player=GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(player!=null){
        if(move)
        transform.position= Vector3.MoveTowards(transform.position,player.transform.position+offset,Towardsspeed*Time.deltaTime);
        
        if(player.transform.parent.parent!=null){
        if(player.transform.parent.parent.tag!="Start")
           
                  transform.Translate(Vector2.up*moveSpeed*Time.deltaTime);
            
        }
        }
      
        }
    }

