using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_GameManager : MonoBehaviour {

    public bool playerTurn;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    if(!playerTurn)
        {
            playerTurn = true;
        }
	}

    void EnemyTurn()
    {
        playerTurn = true;
    }
}
