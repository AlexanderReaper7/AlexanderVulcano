using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour {
	
    public int health = 50;
    public int maxHealth = 100;
    public string Load_Scene_Death;
    public int numberOfObjects = 5;
    public int objectPickedUp = 0;
    public bool win = false;
 
    public void addPickUpNumber()
    {
        objectPickedUp++;
    }
    void Update()
    {
        if(objectPickedUp>=numberOfObjects)
        {
            win = true;
            
        }

    }
    public void SetHealth(int value) {
		health = value;
        
		if (health > maxHealth) {
			health = maxHealth;
		} else if (health <= 0) {
            SceneManager.LoadScene(Load_Scene_Death);
        }

		Debug.Log("Health: " + health + "/" + maxHealth);
	}
}
