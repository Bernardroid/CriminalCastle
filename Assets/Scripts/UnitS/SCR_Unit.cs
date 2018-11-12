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
    int movementRange;
    int dmgRange;
    bool hasMoved;
    SCR_Grid gridManager;

	// Use this for initialization
	void Start () {
        gridManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<SCR_Grid>();
        switch(weaponType)
        {
            case WEAPON_TYPE.SWORD:
                {
                    dmgRange = 1;
                }
                break;
            case WEAPON_TYPE.CQC:
                {
                    dmgRange = 1;
                }
                break;
            case WEAPON_TYPE.MAGIC:
                {
                    dmgRange = 2;
                }
                break;
            case WEAPON_TYPE.SNIPER:
                {
                    dmgRange = 3;
                }
                break;
        }
        switch (movementType)
        {
            case MOVEMENT_TYPE.PIE:
                {
                    movementRange = 2;
                }
                break;
            case MOVEMENT_TYPE.PARKOUR:
                {
                    movementRange = 2;
                }
                break;
            case MOVEMENT_TYPE.FLYER:
                {
                    movementRange = 2;
                }
                break;
            case MOVEMENT_TYPE.MOTO:
                {
                    movementRange = 3;
                }
                break;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Movement()
    {
        for(int i=0; i<(gridManager.nodeRadius*2)*movementRange; i++)
        {

        }
    }

}
