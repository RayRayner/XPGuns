using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestButtons : MonoBehaviour
{

    Player player;
    public Text goldText;
    public Text expText;

    public void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        if (player != null)
            Debug.Log("Found The Player");
        UpdateUI();
    }

    public void KillMob ()
    {
		player.Gold += 100;
		player.Exp += 100;
        UpdateUI();
    }

private void UpdateUI ()
    {
        goldText.text = "Gold: " + player.Gold;
        expText.text = "Exp: " + player.Exp;
    }

}
