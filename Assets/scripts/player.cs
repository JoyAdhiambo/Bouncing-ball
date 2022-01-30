using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
  Rigidbody2D rd;
  public float jumpforce;
  public LayerMask platformMask;
  public float Xoffset;
    void Awake()
    {
       rd=GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetMouseButtonDown(0))
        if(Grounded().collider!=null){
            rd.velocity=new Vector2(rd.velocity.x,jumpforce);
            rd.AddTorque(Random.Range(-15,15));
        }
        else{
            rd.velocity=new Vector2(rd.velocity.x,-jumpforce);
            rd.AddTorque(Random.Range(-15,15));
        }
        ChangeParent();
         ChechCollisionwithScreen();
         Top();
    
    }
    void ChechCollisionwithScreen()
    {
      if(transform.parent.parent==null)
      {
       if(transform.position.x-Xoffset>Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,0,0)).x)
       {
         rd.velocity=Vector2.left*5f;
         rd.AddTorque(Random.Range(-1,1));
       }
       else if(transform.position.x+Xoffset<Camera.main.ScreenToWorldPoint(new Vector3(0,0,0)).x)
       {
         rd.velocity=Vector2.right*5f;
         rd.AddTorque(Random.Range(-1,1));
       }
      }
    }

 void ChangeParent(){
           if(Grounded().collider!=null){
        transform.parent.parent=downhit.transform;
        }
        else{
          transform.parent.parent=null;
        }
        }

  RaycastHit2D downhit;
  RaycastHit2D Grounded(){
downhit=Physics2D.Raycast(transform.position,Vector2.down,0.8f,platformMask);
return downhit;
  }
  RaycastHit2D uphit;
  void Top(){
uphit=Physics2D.Raycast(transform.position,Vector2.up,0.8f,platformMask);
  if(uphit.collider!=null){
    uphit.collider.enabled=false;
  }
  }
}
