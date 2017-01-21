using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave_SimpleFire : MonoBehaviour {

    public GameObject Wave_Emitter;

    public GameObject WaveKind;

    public float FlightSpeed;

    public float FlightLength;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space"))
        {
            GameObject Wave = Instantiate(WaveKind,Wave_Emitter.transform.position, Wave_Emitter.transform.rotation) as GameObject;
            //Wave.transform.Rotate(Vector3.up * 90);
            Rigidbody WaveRigidBody;
            WaveRigidBody = Wave.GetComponent<Rigidbody>();
            WaveRigidBody.AddForce(transform.forward * FlightSpeed);
            //WaveRigidBody.velocity = (transform.forward * FlightSpeed);
            Destroy(Wave, FlightLength);
        }
	}
}
