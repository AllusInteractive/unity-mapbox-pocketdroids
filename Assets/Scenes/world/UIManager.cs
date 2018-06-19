using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    [SerializeField] private Text xpText;
    [SerializeField] private Text levelText;
    [SerializeField] private GameObject menu;

    private void Awake() {

        Assert.IsNotNull(xpText);
        Assert.IsNotNull(levelText);
        Assert.IsNotNull(menu);

    }

    private void Update() {

        Player currentPlayer = GameManager.Instance.CurrentPlayer;
        updateLevel(currentPlayer.Level);
        updateXP(currentPlayer.XP, currentPlayer.RequiredXP);
        
    }

    public void updateLevel(int level)
    {

        levelText.text = level.ToString();

    }

    public void updateXP(int currentXP, int requiredXP)
    {

        xpText.text = currentXP.ToString() + " / " + requiredXP.ToString();

    }

    public void toggleMenu()
    {
        menu.SetActive(!menu.activeSelf);
    }
	
}
