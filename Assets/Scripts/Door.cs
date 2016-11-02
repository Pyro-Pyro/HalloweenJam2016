using UnityEngine;
using System.Collections;
using System;

public class Door : Selectable {

    public Camera main;
    public GameObject initialPos;
    public GameObject hidingPos;
    private bool hiding = false;

    public override void action()
    {

        if(hiding)
        {
            main.transform.position = initialPos.transform.position;
            hiding = false;
        }
        else
        {
            main.transform.position = hidingPos.transform.position;
            hiding = true;
            main.transform.Translate(1, 0, 0);
        }
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
