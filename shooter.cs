using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour {

    public Rigidbody projectile;
    public Transform shotPos;
    public float shotForce = 100;
    public float movespeed = 10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {

        float h = Input.GetAxis("Horizontal") * Time.deltaTime * movespeed;
        float v = Input.GetAxis("Vertical") * Time.deltaTime * movespeed;

        transform.Translate(new Vector3(h, 0,v));

        if(Input.GetButtonUp("Fire1"))
        {

            Rigidbody shot = Instantiate(projectile,shotPos.position,shotPos.rotation)as Rigidbody;
            shot.AddForce(shotPos.forward*shotForce);

        }



    }

    
}
