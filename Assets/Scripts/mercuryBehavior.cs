using UnityEngine;
using System.Collections;

public class mercuryBehavior : MonoBehaviour {

	float PlanetRotateSpeed = 0.25f;
	float OrbitSpeed = 10f;
	GameObject sun;

	// Use this for initialization
	void Start () {
		sun = GameObject.Find("Sun");
	}

	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (0f, 1f, 0f), PlanetRotateSpeed);
		transform.RotateAround (sun.transform.position, sun.transform.up, OrbitSpeed * Time.deltaTime);
	}
}
