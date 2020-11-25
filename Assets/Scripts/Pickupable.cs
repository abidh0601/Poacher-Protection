using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class Pickupable : MonoBehaviour {
	public bool held = true;
	// Use this for initialization
	void Start () {
	
	}

	
	
	// Update is called once per frame
	void Update () {

        if (held)
        {
			GetComponent<NavMeshAgent>().enabled = false;
        }
        else
        {
			GetComponent<NavMeshAgent>().enabled = true;
        }
	}
}
