using UnityEngine;
using System.Collections;

//husk at adde audio scource til game object


public class SoundLoop : MonoBehaviour {


	public AudioSource mysound;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKey (KeyCode.Mouse0)) {
			mysound.enabled = true;
			mysound.loop = true;
		} else {

			mysound.enabled = false;
			mysound.loop = false;

		}
	}
}
