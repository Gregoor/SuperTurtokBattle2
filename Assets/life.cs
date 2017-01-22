using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class life : MonoBehaviour {
    public int currentLife;
    public int maxlife;
    int cd = 6;
    int count = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        cd++;
	}

    void OnCollisionEnter(Collision c)
    {
        count++;
        Debug.Log(count);
        Debug.Log(c.collider.name);
        
        if (cd > 5 & c.collider.tag.Equals("bullet")) { 
        //currentLife = currentLife - 10;
            Debug.Log("lifeloss");
        }
        if ( currentLife <= 0) { Destroy(this.gameObject); }
    }
}
