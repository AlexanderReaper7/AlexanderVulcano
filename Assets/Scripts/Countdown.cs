using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Countdown : MonoBehaviour {

	private float startTime;
	private int restSeconds;
	private int roundedRestSeconds;
	private int displaySeconds;
	private int displayMinutes;
	bool CountUp = false;

	public Text countdownGUI;

	int countdownSeconds;


	// Use this for initialization
	void Start () {
		startTime = Time.time;
	}
	
	// Update is called once per frame
	void OnGUI () {
    //make sure that your time is based on when this script was first called
    //instead of when your game started
    var guiTime = Time.time - startTime;
    if(CountUp == false)
    {
        restSeconds = (int)(countdownSeconds - (guiTime));
    }
    if(CountUp == true)
    {
        restSeconds = (int)(countdownSeconds + (guiTime));
    }
    
    //display messages or whatever here -->do stuff based on your timer
    if (restSeconds == 60) {
        print ("One Minute Left");
    }
    if (restSeconds == 0) {
        print ("Time is Over");
        //do stuff here
    }

    //display the timer
    roundedRestSeconds = Mathf.CeilToInt(restSeconds);
    displaySeconds = roundedRestSeconds % 60;
    displayMinutes = roundedRestSeconds / 60; 

    countdownGUI.text = string.Format ("{0:00}:{1:00}", displayMinutes, displaySeconds); 
    //GUI.Label(Rect (400, 25, 200, 30), text);
	
	}
}
