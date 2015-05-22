using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W))
			gameObject.GetComponent<Transform> ().Translate (Vector3.forward * Time.deltaTime * 5);
		if (Input.GetKey (KeyCode.S))
			gameObject.GetComponent<Transform> ().Translate (Vector3.back * Time.deltaTime * 5);
		if (Input.GetKey (KeyCode.A))
			gameObject.GetComponent<Transform> ().Rotate (0, -Time.deltaTime * 90, 0);
		if (Input.GetKey (KeyCode.D))
			gameObject.GetComponent<Transform> ().Rotate (0, Time.deltaTime * 90, 0);
		if (Input.GetKey (KeyCode.Space))
			gameObject.GetComponent<Transform> ().Translate(Vector3.up * Time.deltaTime * 3);

		if (Input.GetKey (KeyCode.Space))
			gameObject.GetComponent<Animation> ().Play("dragon_take_off");
		else if (Input.GetKey (KeyCode.W))
			gameObject.GetComponent<Animation> ().Play ("dragon_stirr_on_ground");
		else if (Input.GetKey (KeyCode.S))
			gameObject.GetComponent<Animation> ().Play ("dragon_stirr_on_ground");
		else if (Input.GetKey (KeyCode.A))
			gameObject.GetComponent<Animation> ().Play ("dragon_stirr_on_ground");
		else if (Input.GetKey (KeyCode.D))
				gameObject.GetComponent<Animation> ().Play ("dragon_stirr_on_ground");
		else
			gameObject.GetComponent<Animation> ().Play ("dragon_idle");
	}
}
