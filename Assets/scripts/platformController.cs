using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformController : MonoBehaviour
{
    public float speed;
    int sign=1;
    public float Xoffsets;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      transform.Translate(Vector2.right*speed*sign*Time.deltaTime);  
     
    AlterSiqn();
   
    }
    bool reversesign=true;
      void AlterSiqn()
    {
        if(transform.position.x-Xoffsets>Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,0,0)).x&& reversesign){
       reversesign=false;
       Invoke("Reversesign",1f);
         sign*=-1;
         }
        else if(transform.position.x+Xoffsets<Camera.main.ScreenToWorldPoint(new Vector3(0,0,0)).x&& reversesign){
           reversesign=false;
       Invoke("Reversesign",1f);
        sign *=-1;
        }
         if(GetComponent<Collider2D>().enabled=true){
        Invoke("EnableCollider",.2f);
         EnableCollider();
      }
    }
    void Reversesign(){
      reversesign=true;
    }
    void EnableCollider(){
GetComponent<Collider2D>().enabled=true;
    }
    void OnCollisionEnter2D(Collision2D obj){
      if(obj.gameObject.CompareTag("Player")){
        
     GameObject.FindObjectOfType<highscoremanager>().points++;
      }
     
    }
  
}
