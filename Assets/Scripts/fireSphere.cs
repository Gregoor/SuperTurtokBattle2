using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireSphere : MonoBehaviour {
    public GameObject sphere;
    public Transform gun;
    public int speed;
    public int player;
    int cd;
	// Use this for initialization

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis("Shoot 2 player " + player) < 0 & cd > 15)
        {
            var projectile = Instantiate(sphere, gun.position, gun.rotation);
            projectile.GetComponent<sphereMove>().speed = speed;
            Destroy(projectile, 10f);
            cd = 0;
        }
        else cd++;
    }
}
