using UnityEngine;
using System.Collections;

public class CollisionEvent : MonoBehaviour {
	public PlayerManager player;
	public GameObject GameObject;

	public void Awake() {
		print("Hello World!");
		print("Player Health is " + player.health.ToString());
	}

	public void Update() {
				print("Player Health is " + player.health.ToString());
	}

	public void OnCollisionEnter(Collision other) {

		print("Collision with " + other.gameObject.name);
		if(other.gameObject.tag == "Player")  {
			// PlayerManager player = (PlayerManager)other.gameObject.GetComponent(typeof(PlayerManager));
			this.player.SetHealth(-1);
		}
	}
}
