using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMPlayer : MonoBehaviour {
    public AudioSource[] audioSources;

	// Use this for initialization
	void Start () {
        audioSources[0].Play();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
