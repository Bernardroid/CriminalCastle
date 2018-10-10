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

    void Start()
    {
        nodeDiameter = nodeRadius * 2;
        gridSizeX = Mathf.RoundToInt(gridSize.x / nodeDiameter);
        gridSizeY = Mathf.RoundToInt(gridSize.y / nodeDiameter);
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
				Vector3 nodePosition = transform.position + Vector3.right*(x * nodeDiameter) + Vector3.up * (y * nodeDiameter);
                bool walkable = !(Physics.CheckSphere(nodePosition, nodeRadius,unwalkableMask));
                grid[x, y] = new SCR_Node(walkable, nodePosition, x ,y);
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
        Gizmos.DrawWireCube(transform.position, new Vector3(gridSize.x, gridSize.y,1));
        
        if (grid!=null)
        {
            foreach (SCR_Node n in grid)
            {
                Gizmos.color = (n.isWalkable)?Color.white:Color.red;
                Gizmos.DrawCube(n.position, Vector3.one * (nodeDiameter - .1f));
            }
        }
    }
    

}
