﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animateRotation : MonoBehaviour {


	void rotate (float speed) {

		transform.Rotate (Vector3.up, speed);

	}
}
