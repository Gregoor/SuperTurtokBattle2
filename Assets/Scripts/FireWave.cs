using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireWave : MonoBehaviour {

    public string waveOneButton;

    public GameObject waveOne;

    public Transform waveSpawn;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(waveOneButton))
        {

            //var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
            //var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

            //transform.Rotate(0, x, 0);
            //transform.Translate(0, 0, z);

            //Instantiate(waveOne, transform.position, transform.rotation);
            var wave = (GameObject)Instantiate(waveOne,waveSpawn.position,waveSpawn.rotation);

            wave.GetComponent<Rigidbody>().velocity = wave.transform.forward * 6;

            Destroy(wave, 10.0f);
        }

    }
}
