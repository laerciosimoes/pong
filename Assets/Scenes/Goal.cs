using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour
{
	public int Player = 1;
		public Scorekeeper scorekeeper;


	public void GetPoint()
	{
		scorekeeper.AddScore(Player);
	}

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
			
	}
}

