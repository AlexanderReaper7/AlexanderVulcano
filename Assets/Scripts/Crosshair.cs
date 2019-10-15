using UnityEngine;
using System.Collections;

public class Crosshair : MonoBehaviour {

	public Texture2D texture;
	Rect position;

	// Use this for initialization
	void Start () {
		position = new Rect(
			(Screen.width - texture.width) / 2,
			(Screen.height - texture.height) / 2,
			texture.width,
			texture.height);
	}
	
	// Update is called once per frame
	void OnGUI () {
		GUI.DrawTexture(position, texture);
	}
}
