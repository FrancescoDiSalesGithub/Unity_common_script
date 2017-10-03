using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//script per creare un bouncer (tipo sonic the hedgehog)


public class jump : MonoBehaviour {

    public Rigidbody rigid;

	// Use this for initialization
	void Start ()
    {
        rigid = GetComponent<Rigidbody>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        other.GetComponent<Rigidbody>().AddForce(Vector3.forward*20,ForceMode.Force);

    }

    private void OnTriggerStay(Collider other)
    {
        other.GetComponent<Rigidbody>().AddForce(Vector3.up*100,ForceMode.Force);
    }
}
