using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneSpawn : MonoBehaviour
{

    [SerializeField] private GameObject pommePrefab;
    [SerializeField] private Vector3 zoneSize;
    int valeur1;
    int valeur2;

    // Start is called before the first frame update
    void Start()
    {
        valeur1 = Random.Range(1,3);
        valeur2 = Random.Range(1,2);

        InvokeRepeating("CreerPomme",valeur1,valeur2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDrawGizmos(){
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, zoneSize);
    }

    void CreerPomme(){
        GameObject nouvellePomme;

        nouvellePomme = Instantiate(pommePrefab);

        float posAleatoireX = Random.Range(transform.position.x - zoneSize.x / 2,transform.position.x + zoneSize.x / 2);
        float posAleatoireY = Random.Range(transform.position.y - zoneSize.y / 2,transform.position.y + zoneSize.y / 2);
        float posAleatoireZ = Random.Range(transform.position.z - zoneSize.z / 2,transform.position.z + zoneSize.z / 2);

        nouvellePomme.transform.position = new Vector3(posAleatoireX,posAleatoireY,posAleatoireZ);

        valeur1 = Random.Range(1,3);
        valeur2 = Random.Range(0,1);
    }
}
