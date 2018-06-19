using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField]
    private int xp = 0;
    [SerializeField]
    private int requiredXP = 100;
    [SerializeField]
    private int levelBase = 100;
    [SerializeField]
    private List<GameObject> droids = new List<GameObject>();
    private int level = 1;

    public int getXP { get { return xp; } }
    public int getRequiredXP { get { return requiredXP; } }
    public int getLevelBase { get { return levelBase; } }
    public List<GameObject> getDroids { get { return droids; } }

	// Use this for initialization
	void Start () {
        initLevelData();
	}
	
	public void addXP(int xp)
    {
        this.xp = Mathf.Max(0, xp);
    }

    public void addDroid(GameObject droid)
    {
        this.droids.Add(droid);
    }

    private void initLevelData()
    {
        level = (xp / levelBase) +1;
        requiredXP = levelBase * level;

    }

}
