using UnityEngine;
using System.Collections;

public class venusBehavior : MonoBehaviour {

	float PlanetRotateSpeed = 0.25f;
	float OrbitSpeed = 8f;
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
