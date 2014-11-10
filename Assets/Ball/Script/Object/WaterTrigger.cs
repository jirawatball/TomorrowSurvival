using UnityEngine;
using System.Collections;

public class WaterTrigger : MonoBehaviour {

	void OnTriggerStay(Collider other) {
		if (other.tag == "Player"){
			other.GetComponent<PlayerProfile>();
		}
	}
}
