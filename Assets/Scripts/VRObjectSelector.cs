using UnityEngine;
using System.Collections;

public class VRObjectSelector : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
	}

    private bool respond = true;

	// Update is called once per frame
	void Update () {
        if (respond && Input.GetMouseButton(0))
        {
            RaycastHit hit;
            Ray ray = new Ray(transform.position,transform.rotation * Vector3.forward);
            if(Physics.Raycast(ray, out hit))
            {
                Selectable selected = hit.collider.GetComponent<Selectable>();
                if (selected) { selected.action(); }
            }
            respond = false;
        }
        else if ( !Input.GetMouseButton(0) )
        {
            respond = true;
        }
	}
}
