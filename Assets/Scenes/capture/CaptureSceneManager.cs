using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureSceneManager : PocketDroidsSceneManager {

	[SerializeField] private int maxThrowAttempts = 3;
	[SerializeField] private GameObject orb;
	[SerializeField] private Vector3 spawnPoint;
	private int currentThrowAttempts = 0;

	public int MaxThrowAttempts {
		get { return maxThrowAttempts; }
	}

	public int CurrentThrowAttempts {
		get { return currentThrowAttempts; }
	}

	private void Start() {
		calculateMaxThrows();
		currentThrowAttempts = maxThrowAttempts;
	}

	private void calculateMaxThrows() {
		
	}

	public void OrbDestroy() {
		currentThrowAttempts--;

		if (currentThrowAttempts <= 0) {

		} else {
			Instantiate(orb, spawnPoint, Quaternion.identity);
		}
	}

	public override void playerTapped(GameObject player) {

	}

	public override void droidTapped(GameObject droid) {

	}
}
