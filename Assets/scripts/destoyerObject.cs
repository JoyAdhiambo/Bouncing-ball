using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destoyerObject : MonoBehaviour
{
    public GameObject diedpane;
    void OnCollisionEnter2D (Collision2D obj){
        if(obj.gameObject.CompareTag("Player"))
        diedpane.SetActive(true);
        Destroy(obj.gameObject);

    }
}
