using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DeadTrigger : MonoBehaviour {

	public enum TypeOfTrigger { Water, Chasm}
	public TypeOfTrigger Type;

	void OnTriggerStay(Collider other) {
		if (other.tag == "Player"){
			switch (Type)
			{
			case TypeOfTrigger.Water:
				other.GetComponent<PlayerProfile>().Hp -= Time.deltaTime*20;
				break;
			case TypeOfTrigger.Chasm:
				other.GetComponent<PlayerProfile>().Hp = 0;
				break;
			default:
				break;
			}

		}
	}
}
