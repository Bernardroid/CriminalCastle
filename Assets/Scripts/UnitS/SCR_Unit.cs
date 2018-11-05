using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WEAPON_TYPE
{
    SWORD,
    CQC,
    MAGIC,
    SNIPER
}
public enum MOVEMENT_TYPE
{
    PIE,
    PARKOUR,
    FLYER,
    MOTO
}

public class SCR_Unit : MonoBehaviour {
    public WEAPON_TYPE weaponType;
    public MOVEMENT_TYPE movementType;
    public int movement;
    SCR_Grid gridManager;

	// Use this for initialization
	void Start () {
        gridManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<SCR_Grid>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
