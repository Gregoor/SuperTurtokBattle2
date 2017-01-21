using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveOneProperties : MonoBehaviour {

    private float FlightSpeed = 10;

    private float FlightLength = 3;

    public GameObject Wave;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Wave.transform.Rotate(Vector3.up * 90);
        Rigidbody WaveRigidBody;
        WaveRigidBody = Wave.GetComponent<Rigidbody>();
        WaveRigidBody.AddForce(transform.forward * FlightSpeed);
        //WaveRigidBody.velocity = (transform.forward * FlightSpeed);
        Destroy(Wave, FlightLength);
    }
}
