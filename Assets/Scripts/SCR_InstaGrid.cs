using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_InstaGrid : MonoBehaviour {

    public GameObject gridSpace;
    public Transform dynamicBoard;

    int rndX;
    int rndY;

    void Start()
    {



        Board.Tiles = new GameObject[Board.width, Board.height];

        //Create gameboard linked to array
        for (int i = 0; i < Board.width; i++)
        {
            for (int j = 0; j < Board.height; j++)
            {
                rndX = Random.Range(0, 9);
                rndY = Random.Range(0, 9);

                Board.Tiles[i, j] = Instantiate(gridSpace, new Vector3(i, 0, j), Quaternion.identity, dynamicBoard);

                //Assign position in array to object
                Board.Tiles[i, j].GetComponent<SCR_FloorTileInfo>().xPos = i;
                Board.Tiles[i, j].GetComponent<SCR_FloorTileInfo>().yPos = j;


                //Random obstacles
                if (i == rndX || j == rndY)
                {
                    Board.Tiles[i, j].GetComponent<SCR_FloorTileInfo>().walkable = false;
                }
                else
                {
                    Board.Tiles[i, j].GetComponent<SCR_FloorTileInfo>().walkable = true;
                }
            }
        }

        for (int i = 0; i < Board.width; i++)
        {
            for (int j = 0; j < Board.height; j++)
            {
                if (!Board.Tiles[i, j].GetComponent<SCR_FloorTileInfo>().walkable)
                {
                    Board.Tiles[i, j].GetComponent<Renderer>().material.color = Color.black;
                }
            }
        }
    }
}
