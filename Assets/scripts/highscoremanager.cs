using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highscoremanager : MonoBehaviour
{
  public int points;
  public Text highscoretext;
  public GameObject highscoreTextObject;
    void Start()
    {
        if(!PlayerPrefs.HasKey("Points"))
        PlayerPrefs.SetInt("Points",0);
        
    }

    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player")==null){
            if(points>PlayerPrefs.GetInt("Points")){
                highscoreTextObject.SetActive(true);
                PlayerPrefs.SetInt("Points",points);
            }
        }
        highscoretext.text=points.ToString();
    }
}
