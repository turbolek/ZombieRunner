using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eyes : MonoBehaviour {

    private Camera eyes;
    private float defaultFOV;
    public float zoomSpeed = 10f;

	// Use this for initialization
	void Start () {
        eyes = GetComponent<Camera>();
        defaultFOV = eyes.fieldOfView;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Zoom"))
        {
            if (eyes.fieldOfView > defaultFOV / 1.5f)
            {
                eyes.fieldOfView -= Time.deltaTime * zoomSpeed;
            }
                      
        } else
        {
            if (eyes.fieldOfView < defaultFOV)
            {
                eyes.fieldOfView += Time.deltaTime * 2 * zoomSpeed;
            }
        }

     
    }
}
