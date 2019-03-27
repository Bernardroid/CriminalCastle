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
    int baseMovementRange;
    int dmgRange;
    public bool hasMoved;
    public bool isSelected;
    SCR_Grid gridManager;

	// Use this for initialization
	void Start () {
        gridManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<SCR_Grid>();
        
        isSelected = true;
        WeaponTypeStats(weaponType);
        MovementTypeStats(movementType);
    }


    void WeaponTypeStats(WEAPON_TYPE _type)
    {
        switch (_type)
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
    }

    void MovementTypeStats(MOVEMENT_TYPE _type)
    {
        switch (_type)
        {
            case MOVEMENT_TYPE.PIE:
                {
                    baseMovementRange = 2;
                }
                break;
            case MOVEMENT_TYPE.PARKOUR:
                {
                    baseMovementRange = 2;
                }
                break;
            case MOVEMENT_TYPE.FLYER:
                {
                    baseMovementRange = 2;
                }
                break;
            case MOVEMENT_TYPE.MOTO:
                {
                    baseMovementRange = 3;
                }
                break;
        }
    }
	
	// Update is called once per frame
	void Update () {
        CheckMovement();
	}

    void CheckMovement()
    {
        if (isSelected&&!hasMoved)
        {
            //Debug.Log("Node [myNodeX,myNodeY] = [" + gridManager.NodeFromWorldPoint(transform.position).gridX + "," + gridManager.NodeFromWorldPoint(transform.position).gridY + "]");
            for (int i = 0; i < gridManager.gridSize.x; i++)
            {
                for (int j = 0; j < gridManager.gridSize.y; j++)
                {

                    //Debug.Log((gridManager.NodeFromWorldPoint(transform.position).gridX + i)+(gridManager.NodeFromWorldPoint(transform.position).gridY + j));
                    if (Mathf.Abs(i - gridManager.NodeFromWorldPoint(transform.position).gridX) + Mathf.Abs(j - gridManager.NodeFromWorldPoint(transform.position).gridY) <= baseMovementRange)
                    {
                        Debug.Log("Pos="+ transform.position+"X = "+ gridManager.NodeFromWorldPoint(transform.position).gridX + " Y = " + gridManager.NodeFromWorldPoint(transform.position).gridY);
                        Debug.Log(gridManager.grid[i, j].tileType = TILE_TYPE.MOVEABLE);
                    }

                }
            }
        }
    }

}
