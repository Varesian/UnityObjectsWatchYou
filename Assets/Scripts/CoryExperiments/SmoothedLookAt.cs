using UnityEngine;
using System.Collections;

public class SmoothedLookAt : MonoBehaviour {

	public Transform objectToLookAt;
	public float attractionFactor = 0.2f;
	//public float speed = 1.0f;
	
	// Update is called once per frame
	void Update () {
		
		Vector3 vecToTarget = objectToLookAt.transform.position - transform.position;
		//Debug.Log (vecToTarget);	
		Quaternion rotation = Quaternion.LookRotation(vecToTarget);
		//smoothed rotation towards the target
		transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * attractionFactor);
		//move forward along new rotation
		//transform.Translate (Vector3.forward * Time.deltaTime * speed);
	}
}
