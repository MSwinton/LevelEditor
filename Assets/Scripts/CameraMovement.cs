﻿using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {
	public GameObject player;
	private Vector3 offset;
	public float frameSize;
	private GameObject spawn;
	private LevelBuildGui script;

	// Use this for initialization
	void Start () {
		offset = transform.position;
		camera.orthographicSize = frameSize;
		spawn = GameObject.FindWithTag ("GameController");
		script = spawn.GetComponent<LevelBuildGui> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		if (player == null) {
			player = GameObject.FindGameObjectWithTag ("Player");
		
		}if (player != null && script.play ) {
	
						transform.position = player.transform.position + offset;
				}
		if(!script.play){
			if (Input.GetKeyDown (KeyCode.J)) {
				transform.position = new Vector3 (transform.position.x - 0.5f, transform.position.y, transform.position.z);
			}
			if (Input.GetKeyDown (KeyCode.K)) {
				transform.position = new Vector3 (transform.position.x, transform.position.y - 0.5f, transform.position.z);
			}
			if (Input.GetKeyDown (KeyCode.L)) {
				transform.position = new Vector3 (transform.position.x + 0.5f, transform.position.y, transform.position.z);
			}
			if (Input.GetKeyDown (KeyCode.I)) {
				transform.position = new Vector3 (transform.position.x, transform.position.y + 0.5f, transform.position.z);
			}
		} 
	}
}
