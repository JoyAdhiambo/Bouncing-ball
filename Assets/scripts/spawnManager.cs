using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
   GameObject player;
   GameObject spawn;
   public GameObject platform;
   public float Minx;
   public float MaxX;
    float toadd;
   public float distancebetweenplayerandplatform;
   public float distancebwnplatforms;
    void Awake()
    {
      player=GameObject.FindGameObjectWithTag("Player");
      for(int i=0;i<5;i++)
      Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        if(player!=null){
            if(spawn.transform.position.y-player.transform.position.y<=distancebetweenplayerandplatform){
                Spawn();
            }
        }
    }
    void Spawn(){
        spawn=Instantiate(platform);
        toadd+=distancebwnplatforms;
        spawn.transform.position= new Vector2(Random.Range(Minx,MaxX),toadd);
    }
}
