using UnityEngine;
using System.Collections;

public class ActiveObject : MonoBehaviour {

	public enum TypeOfTrigger { Door, Something}
	public TypeOfTrigger Type;
	public GameObject ObjectSender;
	
	void OnTriggerStay(Collider other) {
		if (other.tag == "Player"){
			switch (Type)
			{
//			case TypeOfTrigger.Water:
//				other.GetComponent<PlayerProfile>().Hp -= Time.deltaTime*20;
//				break;
//			default:
//				break;
			}
			
		}
	}
}
