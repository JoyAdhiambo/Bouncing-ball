using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leveloader : MonoBehaviour
{
    public GameObject Loadingpanel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Load(string lvlname){
        Loadingpanel.SetActive(true);
        Application.LoadLevel(lvlname);
    }
}
