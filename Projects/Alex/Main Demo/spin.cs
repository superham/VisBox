//these are the basic libraries included for most 3-d game objects in unity
//this is special for the front fins
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour { //this runs once

    public int speed;
	void Start () {
	}
	

	void Update () { //this loop runs every frame
		transform.Rotate(Vector3.forward * speed * Time.deltaTime, Space.Self);/*z is forward, speed is a var, the del. time is the time from whenthe last scene was rendered, space.self is a coord. ref.*/
	}
}
