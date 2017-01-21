using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class life : MonoBehaviour {
    public int currentLife;
    public int maxlife;
    int cd = 6;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        cd++;
	}

    void OnCollisionEnter(Collision c)
    {
        Debug.Log(c.collider.gameObject.name);
        if (cd > 5 & c.collider.gameObject.name.Equals("wave")) { 
        currentLife = currentLife - 10;
        }
        if ( currentLife <= 0) { Destroy(this.gameObject); }
    }
}
