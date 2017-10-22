using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public bool spawnTrigger = false;

    List<GameObject> spawnPlaces = new List<GameObject>();

	// Use this for initialization
	void Start () {
        GameObject spawnPlacesParent = GameObject.Find("PlayerSpawnPoints");
        foreach (Transform child in spawnPlacesParent.transform)
        {
            spawnPlaces.Add(child.gameObject);
        }
	}
	
	// Update is called once per frame
	void Update () {
		if(spawnTrigger)
        {
            Spawn();
        }
	}

    private void Spawn () {
        GameObject spawnPlace = spawnPlaces[Random.Range(0, spawnPlaces.Count)];
        transform.position = spawnPlace.transform.position;
        spawnTrigger = false;
    }
}
