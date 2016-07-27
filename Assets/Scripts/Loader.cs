using UnityEngine;
using System.Collections;

public class Loader : MonoBehaviour {

	public GameObject gameManager;


	void Update () 
	{
		if (GameManager.instance == null)
			Instantiate (gameManager);
	}
	}
