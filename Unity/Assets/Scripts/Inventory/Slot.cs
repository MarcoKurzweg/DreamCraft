using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour {
	public GameObject equippedItem;
	// Use this for initialization
	public Item item;
	public void Start() {
		 item = equippedItem.GetComponent<Item>();
		 
	}

	public void Use() {

	}
}
