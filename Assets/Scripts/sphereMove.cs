using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereMove : MonoBehaviour
{
    public float current;
    public int max = 100;
    bool up = false;
    int pause = 0;
    public int speed;
    Renderer rend;
    // Use this for initialization
    void Start()
    {
        Debug.Log(transform.rotation.eulerAngles.normalized.ToString());
        this.GetComponent<Rigidbody>().velocity = transform.forward * speed;
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (up)
        {
            current = current + 5f;
            if (current >= max) { up = false; }
        }
        else
        {
            current = current - 5f;
            if (current <= 0) { up = true; }
        }
        //this.gameObject.transform.localScale.Set(currentscale, currentscale, currentscale);

        

        if (current < 40)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.black;
            this.GetComponent<SphereCollider>().enabled = false;
        }
        else
        {
            this.GetComponent<SphereCollider>().enabled = true;
            gameObject.GetComponent<Renderer>().material.color = new Color(current + 155, 5, 5);
            
        }
    }
}
