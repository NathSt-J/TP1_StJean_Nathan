using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aigle : MonoBehaviour
{

    [SerializeField] private float vitesse = 1f;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        BougeAigle();
    }

    void BougeAigle()
    {
        rb.velocity = Vector3.forward * -vitesse;
    }
}
