using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameCamera : MonoBehaviour {

    public GameObject gameobject;
    private Vector3 offset;
    public Camera camera;

	// Use this for initialization
	void Start ()
    {
        offset = transform.position - gameobject.transform.position;
        camera = GetComponent<Camera>();
    }
	

    public void ZoomCamera()
    {

        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {

            camera.fieldOfView += 1f;


        }

        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {

            camera.fieldOfView -= 1f;


        }
        
    }

    public void CameraTracking()
    {

        transform.position = gameobject.transform.position + offset;

    }

	// Update is called once per frame
	void Update ()
    {

        CameraTracking();
        ZoomCamera();
               

    }

    

}
