using UnityEngine;
using System.Collections;

public class CubeBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		MoveByKeys();
	}

	void MoveByKeys() {
		if (Input.GetKey(KeyCode.DownArrow)){
			transform.Translate (0f, 0f, -1f * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.UpArrow)){
			transform.Translate (0f, 0f, 1f * Time.deltaTime);
		}

		if (Input.GetKey(KeyCode.RightArrow)){
			transform.Translate (1f * Time.deltaTime, 0f, 0f);
		}
		if (Input.GetKey(KeyCode.LeftArrow)){
			transform.Translate (-1f * Time.deltaTime, 0f, 0f);
		}
	}
}
