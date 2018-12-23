using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoButton : MonoBehaviour {

    public static bool buttonGO = false;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        buttonGO = true;
        if (buttonGO == true)
        {
            PlayerController.pilihArrow = true;
            buttonGO = false;
        }
    }
}
