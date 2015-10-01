using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {

	float speedX = 0;
	float speedY = -1;
	float speedZ = 0;
	public float depth = -10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		float pos = this.transform.position.y;
		if (pos > depth) {
			transform.Translate (new Vector3 (speedX, speedY, speedZ) * Time.deltaTime);
		}
	}
}
