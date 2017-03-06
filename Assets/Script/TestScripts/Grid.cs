using UnityEngine;
using System.Collections;

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

    private GameObject[,] m_grid;


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
        
        for (int y = 0; y < m_columns; y++)
        {
            for (int x = 0; x < m_rows; x++)
            {
                GameObject newTile = Instantiate(m_tile);
                newTile.name = "Tile" + y.ToString() + x.ToString();

                m_grid[x, y] = newTile;

                if (x > 0 && y == 0)
                    newTile.transform.position = new Vector3((m_LeftmostPos + x * m_gapX) + (tileWidth * x), m_LowestPos - (tileHeight * y), 0);
                else if (x >= 0 && y > 0)
                    newTile.transform.position = new Vector3((m_LeftmostPos + x * m_gapX) + (tileWidth * x), (m_LowestPos + y * m_gapY) + (tileHeight * y), 0);
                else //if x and y == 0
                    newTile.transform.position = new Vector3(m_LeftmostPos - (tileWidth * x), m_LowestPos - (tileHeight * y), 0);
            }
        }
    }

    void UpdateGrid()
    {
        float tileWidth = m_tile.GetComponent<SpriteRenderer>().bounds.size.x;
        float tileHeight = m_tile.GetComponent<SpriteRenderer>().bounds.size.y;


        for (int y = 0; y < 4; y++)
        {
            for (int x = 0; x < 7; x++)
            {
                if (x > 0 && y == 0)
                    m_grid[x, y].transform.position = new Vector3((m_LeftmostPos + x * m_gapX) + (tileWidth * x), m_LowestPos - (tileHeight * y), 0);
                else if (x >= 0 && y > 0)
                    m_grid[x, y].transform.position = new Vector3((m_LeftmostPos + x * m_gapX) + (tileWidth * x), (m_LowestPos + y * m_gapY) + (tileHeight * y), 0);
                else //if x and y == 0
                    m_grid[x, y].transform.position = new Vector3(m_LeftmostPos - (tileWidth * x), m_LowestPos - (tileHeight * y), 0);
            }
        }
    }
}
