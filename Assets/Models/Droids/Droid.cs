using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Droid : MonoBehaviour {

	[SerializeField] private float spawnRate = 0.1f;
	[SerializeField] private float catchRate = 0.1f;
	[SerializeField] private int attack = 0;
	[SerializeField] private int defense = 0;
	[SerializeField] private int hp = 10;

	private void Start() {
		DontDestroyOnLoad(this);
	}

	public float SpawnRate { get { return spawnRate; } }
	public float CatchRate { get { return catchRate; } }
	public int Attack { get { return attack; } }
	public int Defense { get { return defense; } }
	public int HP { get { return hp; } }
	
	private void OnMouseDown()
	{
		
		PocketDroidsSceneManager[] managers = FindObjectsOfType<PocketDroidsSceneManager>();
		foreach (PocketDroidsSceneManager manager in managers)
		{

			if(manager.gameObject.activeSelf)
				manager.droidTapped(this.gameObject);
			
		}

	}
	
}
