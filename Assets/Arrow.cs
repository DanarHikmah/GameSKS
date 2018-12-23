using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour {

    private Sprite[] arrowSides;
    private SpriteRenderer renderer;
    private int indexArrow = 0;

	// Use this for initialization
	void Start () {
        renderer = GetComponent<SpriteRenderer>();
        arrowSides = Resources.LoadAll<Sprite>("ArrowSides/");
        renderer.sprite = arrowSides[3];
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    private void OnMouseDown()
    {
        if(indexArrow+1 >= arrowSides.Length)
        {
            indexArrow = -1;
        }
        renderer.sprite = arrowSides[++indexArrow];
        PlayerController.arah = indexArrow;
        if (PlayerController.selectDirection == true)
        {
            PlayerController.pilihArrow = true;
        }
    }

    

}
