using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_Grid : MonoBehaviour {

    public Vector2 gridSize;
    public float nodeRadius;
    public LayerMask unwalkableMask;
    public LayerMask typeMask;
    public SCR_Node[,] grid;
    float nodeDiameter;
    int gridSizeX;
    int gridSizeY;
    RaycastHit hitter;

    void Start()
    {
        nodeDiameter = nodeRadius * 2;
        gridSizeX = Mathf.RoundToInt(gridSize.x / nodeDiameter);
        gridSizeY = Mathf.RoundToInt(gridSize.y / nodeDiameter);
        CreateGrid();

    }
    void Update()
    {
        CreateGrid();
    }

    public void CreateGrid()
    {
        grid = new SCR_Node[gridSizeX, gridSizeY];
        for (int x=0; x<gridSizeX;x++)
        {
            for (int y = 0; y < gridSizeY; y++)
            {
				Vector3 nodePosition = transform.position + Vector3.right*(x * nodeDiameter) + Vector3.forward * (y * nodeDiameter);
                bool walkable = !(Physics.CheckSphere(nodePosition, nodeRadius,unwalkableMask));
                bool passable = false;
                if (walkable)
                {
                    TILE_TYPE tempTile= new TILE_TYPE();
                    //Debug.Log(nodePosition +"Walkable "+ walkable);
                    if (Physics.Raycast(nodePosition + Vector3.up, Vector3.down, out hitter, 5, typeMask))
                    {
                        passable = true;
                        //Debug.Log(hitter.transform.name);
                        if (hitter.collider.CompareTag("Floor"))
                        {
                            tempTile = TILE_TYPE.FLOOR;
                        }
                        else if(hitter.collider.CompareTag("Stairs"))
                        {
                            tempTile = TILE_TYPE.STAIRS;
                        }
                        else if (hitter.collider.CompareTag("Highground"))
                        {
                            tempTile = TILE_TYPE.HIGHGROUND;
                        }
                        else if (hitter.collider.CompareTag("Hideout"))
                        {
                            tempTile = TILE_TYPE.HIDEOUT;
                        }
                        else if (hitter.collider.CompareTag("Buff"))
                        {
                            tempTile = TILE_TYPE.BUFF;
                        }
                        else if(hitter.collider.CompareTag("Debuff"))
                        {
                            tempTile = TILE_TYPE.DEBUFF;
                        }
                        grid[x, y] = new SCR_Node(walkable, passable, nodePosition, x, y, tempTile);
                    }
                    else
                    {
                        
                        //Debug.Log("Not Hittin");
                        grid[x, y] = new SCR_Node(walkable, passable, nodePosition, x, y, TILE_TYPE.FLOOR);
                    }
                }
                else
                {
                    if (Physics.Raycast(nodePosition + Vector3.up, Vector3.down, out hitter, 5, unwalkableMask))
                    {
                        if (hitter.collider.CompareTag("Player"))
                        {
                            passable = true;
                        }
                    }
                    //Debug.Log("Walkable: " + walkable + "Passable: " + passable);
                    grid[x, y] = new SCR_Node(walkable, passable, nodePosition, x, y, TILE_TYPE.OTHER);
                }
            }
        }
    }
    public SCR_Node NodeFromWorldPoint(Vector3 worldPosition)
    {
        float percentX = (worldPosition.x - transform.position.x) / gridSize.x + 0.5f;
        float percentY = (worldPosition.y - transform.position.y) / gridSize.y + 0.5f;

        percentX = Mathf.Clamp01(percentX);
        percentY = Mathf.Clamp01(percentY);
        int x = Mathf.RoundToInt((gridSizeX - 1) * percentX);
        int y = Mathf.RoundToInt((gridSizeY - 1) * percentY);
        return grid[x, y];
    }
    
    void OnDrawGizmos()
    {
        if (grid!=null)
        {
            foreach (SCR_Node n in grid)
            {
                //Gizmos.color = (n.isWalkable)?Color.white:Color.red;
                if (n.isWalkable)
                {
                    switch (n.tileType)
                    {
                        case TILE_TYPE.FLOOR:
                            Gizmos.color = Color.white;
                            break;
                        case TILE_TYPE.STAIRS:
                            Gizmos.color = new Color(0.75f, 0.75f, 0.75f);
                            break;
                        case TILE_TYPE.HIGHGROUND:
                            Gizmos.color = Color.grey;
                            break;
                        case TILE_TYPE.HIDEOUT:
                            Gizmos.color = Color.black;
                            break;
                        case TILE_TYPE.BUFF:
                            Gizmos.color = Color.blue;
                            break;
                        case TILE_TYPE.DEBUFF:
                            Gizmos.color = Color.green;
                            break;
                        case TILE_TYPE.OTHER:
                            Gizmos.color = Color.red;
                            break;
                    }
                }
                else
                {
                    Gizmos.color = Color.red;
                }
                Gizmos.DrawCube(n.position, Vector3.one * (nodeDiameter - .1f));
            }
        }
    }
    

}
