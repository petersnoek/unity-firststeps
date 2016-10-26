using UnityEngine;
using System.Collections;

public class SphereController : MonoBehaviour {

	public float Speed;

	public Rigidbody rb;

	// Use this for initialization
	void Start () {
		transform.position = new Vector3 (0, 0, 0);	
		rb = GetComponent<Rigidbody> ();

		rb.velocity = new Vector3 (0, 10, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown (KeyCode.A)) {
			rb.velocity = new Vector3 (-5, 0, 0);
		}

		if (Input.GetKeyDown (KeyCode.D)) {
			rb.velocity = new Vector3 (5, 0, 0);
		}
			
		if (Input.GetKeyDown (KeyCode.Space)) {
			rb.velocity = new Vector3 (0, 10, 0);
		}

	}
}
