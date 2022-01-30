using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pauseResume : MonoBehaviour
{
  public Sprite pause;
  public Sprite resume;
  Image current;
    void Awake()
    {
        current=GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void pauseandResume(){
        if(current.sprite==pause){
            current.sprite=resume;
        Time.timeScale=0;
        }
      else if(current.sprite==resume){
          current.sprite=pause;
            Time.timeScale=1;
      }
           
    }
}
