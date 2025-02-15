﻿using UnityEngine;
using System.Collections;

public class WaypointMovement : MonoBehaviour {
	
	public GameObject player;


	public float height = 0;
	public bool teleport = true;

	public float maxMoveDistance = 10;
	//private bool moving = false;




	public void Move(GameObject waypoint) {
		if (!teleport) {
			iTween.MoveTo (player, 
				iTween.Hash (
					"position", new Vector3 (waypoint.GetComponent<Transform> ().position.x, waypoint.GetComponent<Transform> ().position.y + height / 2, waypoint.GetComponent<Transform> ().position.z), 
					"time", .3F, 
					"easetype", "linear"
				)
			);
		} else {
			player.transform.position = new Vector3 (waypoint.GetComponent<Transform> ().position.x, waypoint.GetComponent<Transform> ().position.y + height / 2, waypoint.GetComponent<Transform> ().position.z);
		}
	}

}

