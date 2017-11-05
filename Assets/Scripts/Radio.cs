using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour {

    private AudioSource audioSource;
    private bool called = false;

	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton("CallHeli") && !called)
        {
            called = true;
            audioSource.Play();
        }
	}
}
