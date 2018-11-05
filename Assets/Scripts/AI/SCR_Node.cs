using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum TILE_TYPE
{
FLOOR,
STAIRS,
HIGHGROUND,
HIDEOUT,
BUFF,
DEBUFF,
OTHER
}
public class SCR_Node{

    public bool isWalkable;
    public bool isPassable;
    public Vector3 position;
    public int gridX;
    public int gridY;
    public SCR_Node parent;
    public TILE_TYPE tileType;


    public SCR_Node(bool _isWalkable, bool _isPassable,Vector3 _position, int _gridX, int _gridY)
    {
        isWalkable = _isWalkable;
        position = _position;
        gridX = _gridX;
        gridY = _gridY;

    }
    public SCR_Node(bool _isWalkable, bool _isPassable, Vector3 _position, int _gridX, int _gridY,TILE_TYPE _tile)
    {
        isWalkable = _isWalkable;
        position = _position;
        gridX = _gridX;
        gridY = _gridY;
        tileType = _tile;
    }
}
