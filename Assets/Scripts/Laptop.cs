using UnityEngine;
using System.Collections;
using System;

public class Laptop : Selectable {

    public Material work;
    public GameObject screen;

    public override void action()
    {
        screen.GetComponent<Renderer>().material = work;
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
    }

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
	}
}
