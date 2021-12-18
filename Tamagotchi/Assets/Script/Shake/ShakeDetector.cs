using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using EZCameraShake;


[RequireComponent(typeof(PhysicsController))]
public class ShakeDetector : MonoBehaviour
{
    public float ShakeDetectionThreshold;
    public float MinShakeInterval;
    private float sqrShakeDetectionThreshold;
    private float timeSinceLastShake;
    private PhysicsController physicsController; 
    public Text ShakeText;
    public int Shakecounter = 0;
   

    // Start is called before the first frame update
    void Start()
    {
        sqrShakeDetectionThreshold = Mathf.Pow(ShakeDetectionThreshold, 2);
        physicsController = GetComponent<PhysicsController>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.acceleration.sqrMagnitude >= sqrShakeDetectionThreshold
            && Time.unscaledTime >= timeSinceLastShake + MinShakeInterval)
        {
            physicsController.ShakeRigidBodies(Input.acceleration);
            timeSinceLastShake = Time.unscaledTime;
            point.points = point.points + 1;
            ShakeText.text = Shakecounter.ToString();
            Shakecounter += 1;

            CameraShaker.Instance.ShakeOnce(4f,3f, .2f,.2f);

        }
    }
}
