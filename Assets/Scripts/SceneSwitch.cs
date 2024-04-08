using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{

    public Points script;

    void OnTriggerEnter(Collider other){
        if(script.points >= 7 && other.gameObject.CompareTag("ArcheFinal")){
            SceneManager.LoadScene(4);
        }
        else SceneManager.LoadScene(2);

    }
}
