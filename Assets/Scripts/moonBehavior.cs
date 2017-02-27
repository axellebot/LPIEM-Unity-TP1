using UnityEngine;
using System.Collections;

public class moonBehavior : MonoBehaviour {

	float PlanetRotateSpeed = 0.125f;
	float OrbitSpeed = 50f;
	GameObject earth;

	// Use this for initialization
	void Start () {
		earth = GameObject.Find("Earth");
	}

	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (0f, 1f, 0f), PlanetRotateSpeed);
		transform.RotateAround (earth.transform.position, earth.transform.up, OrbitSpeed * Time.deltaTime);
	}
}
