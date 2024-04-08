using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{


    private int points;
    private bool hasEntered;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("ArchePoints") && !hasEntered){
            hasEntered = true;
            points++;
        }
        Debug.Log("J'ai présentement: " + points + " points!");
    }
}
