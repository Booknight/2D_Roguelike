using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

	public float turnDelay = .1f;
	public static GameManager instance = null;
	public BoardManager boardScript;
	public int playerFoodPoints = 100;
	[HideInInspector] public bool playersTurn = true;


	private int level = 3;
	private List <Enemy> enemies;
	private bool enemiesMoving;


	// Use this for initialization
	void Awake ()
	{
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);

		DontDestroyOnLoad (gameObject);
		enemies = new List<Enemy> ();
		boardScript = GetComponent<BoardManager> ();
		InitGame ();
	}

	void InitGame()
	{
		enemies.Clear ();
		boardScript.SetupScene (level);
	}

	public void GameOver()
	{
		enabled = false;
	}

	// Update is called once per frame
	void Update () {
	
	}
}
