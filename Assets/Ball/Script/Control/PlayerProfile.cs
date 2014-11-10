using UnityEngine;
using System.Collections;

public class PlayerProfile : MonoBehaviour {

	public float Hp;
	public float OrSpeed;
	public GameObject Torch;
	private CharacterController GetSpeed;

	private bool TurnOn;

	// Use this for initialization
	void Start () {
		Hp = 100;
		Torch.SetActive(false);
		GetSpeed.GetComponent<CharacterMotorC> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Hp<=0)
		{
			Dead();
		}

		Turch ();
	}
	void Run()
	{
		if (Input.GetKey (KeyCode.LeftShift)) 
		{

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
