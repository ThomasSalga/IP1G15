using UnityEngine;
using System.Collections.Generic;

public class Grid : MonoBehaviour {

    [SerializeField]
    private GameObject m_tile;

    [SerializeField]
    int m_rows;
    [SerializeField]
    int m_columns;
    [SerializeField]
    float m_LeftmostPos;
    [SerializeField]
    float m_LowestPos;
    [SerializeField]
    float m_gapX;
    [SerializeField]
    float m_gapY;

    public static GameObject[,] m_grid;


    public float MyLeftmostPos
    {
        get { return m_LeftmostPos; }
        set { m_LeftmostPos = value; }
    }

    public float MyLowestPos
    {
        get { return m_LowestPos; }
        set { m_LowestPos = value; }
    }

    // Use this for initialization
    void Start ()
    {
        InizializeGrid();
    }
	
	// Update is called once per frame
	void Update ()
    {
        
    }

    void InizializeGrid()
    {
        m_grid = new GameObject[m_rows, m_columns];
        float tileWidth = m_tile.GetComponent<SpriteRenderer>().bounds.size.x;
        float tileHeight = m_tile.GetComponent<SpriteRenderer>().bounds.size.y;
        
        for (int y = 0; y < m_rows; y++)
        {
            for (int x = 0; x < m_columns; x++)
            {
                GameObject newTile = Instantiate(m_tile);
                newTile.name = "Tile" + x.ToString() + y.ToString();

                newTile.GetComponent<Cell>().MyColumn = x;
                newTile.GetComponent<Cell>().MyRow = y;

                m_grid[y, x] = newTile;

                if (x > 0 && y == 0)
                    newTile.transform.position = new Vector3((m_LeftmostPos + x * m_gapX) + (tileWidth * x), m_LowestPos - (tileHeight * y), 0);
                else if (x >= 0 && y > 0)
                    newTile.transform.position = new Vector3((m_LeftmostPos + x * m_gapX) + (tileWidth * x), (m_LowestPos + y * m_gapY) + (tileHeight * y), 0);
                else //if x and y == 0
                    newTile.transform.position = new Vector3(m_LeftmostPos - (tileWidth * x), m_LowestPos - (tileHeight * y), 0);
            }
        }

        LockHalfGrid();
    }

    public void LockHalfGrid()
    {
        for (int y = 0; y < m_rows; y++)
        {
            for (int x = m_columns / 2; x >= 0; x--)
            {
                m_grid[y, x].GetComponent<Cell>().IsBlocked = true;
            }
        }
    }

    public void FullGrid()
    {
        for (int y = 0; y < m_rows; y++)
        {
            for (int x = m_columns / 2; x >= 0; x--)
            {
                m_grid[y, x].GetComponent<Cell>().IsBlocked = false;
            }
        }
    }

    public bool IsPlaceable(int x, int y)
    {
        if (x >= 0 && y < m_rows)
        {
            if (m_grid[y, x].gameObject.GetComponent<Cell>().IsBlocked)
            {
                return false;
            }
            else return true; 
        }
        return false;
    }

    public void BlockCells(List<Vector2> vectorList)
    {
        foreach (Vector2 vector in vectorList)
        {
            m_grid[(int)vector.y, (int)vector.x].gameObject.GetComponent<Cell>().LockThis();
        }
    }

    public bool FreeCells(List<Vector2> vectorList)
    {
        foreach (Vector2 vector in vectorList)
        {
            m_grid[(int)vector.y, (int)vector.x].gameObject.GetComponent<Cell>().UnlockThis();
        }
        return true;
    }
}
