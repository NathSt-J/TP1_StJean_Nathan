using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour
{

    // Pour les Wheel Colliders
    [SerializeField] WheelCollider frontRight;
    [SerializeField] WheelCollider frontLeft;
    [SerializeField] WheelCollider backRight;
    [SerializeField] WheelCollider backLeft;

    // Pour les Wheel Meshes
    // [SerializeField] Transform frontRightTransform;
    // [SerializeField] Transform frontLeftTransform;
    // [SerializeField] Transform backRightTransform;
    // [SerializeField] Transform backLeftTransform;

    public float acceleration = 500f;
    public float breakingForce = 300f;
    public float maxTurnAngle = 15f;

    private float currentAcceleration = 0f;
    private float currentBreakForce = 0f;
    private float currentTurnAngle = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Vitesse avant/arrière sur axes verticals (W et S)
        currentAcceleration = acceleration * Input.GetAxis("Vertical");


        // Donne une valeur à currentBreakingForce si barre d'espace est appuyée
        if (Input.GetKey(KeyCode.Space))
            currentBreakForce = breakingForce;
        else
            currentBreakForce = 0f;


        // Accélération sur roues avant
        frontRight.motorTorque = currentAcceleration;
        frontLeft.motorTorque = currentAcceleration;

        frontRight.brakeTorque = currentBreakForce;
        frontLeft.brakeTorque = currentBreakForce;
        backRight.brakeTorque = currentBreakForce;
        backLeft.brakeTorque = currentBreakForce;

        // Pour faire tourner la voiture
        currentTurnAngle = maxTurnAngle * Input.GetAxis("Horizontal");
        frontLeft.steerAngle = currentTurnAngle;
        frontRight.steerAngle = currentTurnAngle;

        // Update pour les Wheel Meshes
        // UpdateWheel(frontLeft, frontLeftTransform);
        // UpdateWheel(frontRight, frontRightTransform);
        // UpdateWheel(backLeft, backLeftTransform);
        // UpdateWheel(backRight, backRightTransform);
    }

    // void UpdateWheel(WheelCollider col, Transform trans){

    //     // State du Wheel Collider
    //     Vector3 position;
    //     Quaternion rotation;
    //     col.GetWorldPose(out position, out rotation);

    //     // Changer le transform state
    //     trans.position = position;
    //     trans.rotation = rotation;
    // }

}
