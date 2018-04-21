using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{

    public int MapSizeX = 20; //20x20
    public int MapSizeY = 20;
    Transform[] AllGridPoints;

	// Use this for initialization
	void Start ()
    {
        MakeMapGrid();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void MakeMapGrid()
    {
        AllGridPoints = new Transform[MapSizeX * MapSizeY];
        int counter = 0;
        for(int x = 0; x < MapSizeX; x++)
        {
            for (int y = 0; y < MapSizeY; y++)
            {
                AllGridPoints[counter] = new GameObject("GridPoint").transform;
                AllGridPoints[counter].position = new Vector3(x, y, 0);
                AllGridPoints[counter].parent = transform;
                AllGridPoints[counter].localScale *= 0.92f;
                SpriteRenderer img = AllGridPoints[counter].gameObject.AddComponent<SpriteRenderer>();
                img.sprite = Resources.Load<Sprite>("GridPointImg");
                img.color = new Color(0, 0, 0, 0.1f);

                GridPoint point = AllGridPoints[counter].gameObject.AddComponent<GridPoint>();


                counter++;
            }
        }
    }
}
