using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour {
	public GameObject equippedItem;
	// Use this for initialization
	public Item item;
	public Image imageContainer;
	public Sprite itemImage;
	public void Start() {
		item = equippedItem.GetComponent<Item>();
		imageContainer = GetComponent<Image>();
		itemImage = item.Sprite;
		Debug.Log(item.Sprite);
		imageContainer.sprite = itemImage;
		
		
		 
	}

	public void Use() {

	}
}
