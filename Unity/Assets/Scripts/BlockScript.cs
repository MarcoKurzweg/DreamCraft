using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
		//left-click
		if (Input.GetMouseButtonDown(0)) {
			Destroy(this.gameObject);
		//right-click
		} else if(Input.GetMouseButtonDown(1)) {

		}
        
    }

	private void OnMouseOver() 
	{
		
	}
}
