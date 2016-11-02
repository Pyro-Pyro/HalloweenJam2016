using UnityEngine;
using System.Collections;
using System;

public class Screen : Selectable
{

    public Material lift;
    public Camera liftc;
    public Material atrium;
    public Camera atriumc;
    public Material labside;
    public Camera labsidec;
    private int count = 0;

    public override void action()
    {
        if(count == 0)
        { liftc.enabled = true; GetComponent<Renderer>().material = lift; count++; atriumc.enabled = false; labsidec.enabled = false; }
        else if(count == 1)
        { atriumc.enabled = true; GetComponent<Renderer>().material = atrium; count++; liftc.enabled = false; labsidec.enabled = false; }
        else
        { labsidec.enabled = true; GetComponent<Renderer>().material = labside; count = 0; liftc.enabled = false; atriumc.enabled = false; }
        
    }

    // Use this for initialization
    void Start()
    {
        liftc.enabled = true;
        atriumc.enabled = false;
        labsidec.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
    }
}