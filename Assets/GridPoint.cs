using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridPoint : MonoBehaviour
{
    private Color OriginalColor;

	// Use this for initialization
	void Start ()
    {
        OriginalColor = transform.GetComponent<SpriteRenderer>().color;
		if(!gameObject.GetComponent<BoxCollider2D>())
        {
            gameObject.AddComponent<BoxCollider2D>();
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnMouseEnter()
    {
        transform.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 0.02f);
    }

    private void OnMouseExit()
    {
        transform.GetComponent<SpriteRenderer>().color = OriginalColor;
    }

    private void OnMouseDown()
    {
        transform.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 0.25f);
        Instantiate(Resources.Load<GameObject>("TowerMenu"), transform);
    }

    private void OnMouseUp()
    {
        transform.GetComponent<SpriteRenderer>().color = OriginalColor;
        if(transform.Find("TowerMenu(Clone)").gameObject)
        {
            Destroy(transform.Find("TowerMenu(Clone)").gameObject);
        }
    }

}
