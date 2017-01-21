using UnityEngine;

public class FireWave : MonoBehaviour {

    public int player;

    public GameObject waveOne;

    public Transform waveSpawn;

	void Update () {
        if (Input.GetAxis("Shoot player " + player) > 0)
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
