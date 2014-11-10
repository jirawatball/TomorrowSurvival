using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerProfile : MonoBehaviour {

	public float Hp;
	public float OrSpeed;
	public GameObject Torch;
	private CharacterMotorC GetSpeed;

	public bool Run;
	public bool Sit;
	private bool TurnOn;
	private float TimeLight;
	private float TimePlay;
	private float TimeRun = 50f;

	public GameObject[] Inventory;
	// Use this for initialization
	void Start () {
		Hp = 100;
		Torch.SetActive(false);
		GetSpeed = gameObject.GetComponent<CharacterMotorC>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Hp<=0)
		{
			Dead();
		}
		ChackStatePlayer ();
		Turch ();
	}
	void ChackStatePlayer()
	{
		if ((Input.GetKey (KeyCode.LeftShift)||Input.GetKey (KeyCode.RightShift))&& TimeRun >0) 
		{
			TimeRun -= Time.deltaTime;
			Run = true;
		}
		else if (Input.GetKeyDown (KeyCode.C)) 
		{
			Sit = true;
		}
	}
	void Turch()
	{
		if (Input.GetKeyDown (KeyCode.E)) {
			if(TurnOn==false)
			{
				Torch.SetActive(true);
				TurnOn = true;
			}else{
				Torch.SetActive(false);
				TurnOn = false;
			}
		}
	}
	void Dead()
	{
		Application.LoadLevel("Main");
	}
}
