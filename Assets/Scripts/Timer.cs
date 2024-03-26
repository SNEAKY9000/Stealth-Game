using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public static event System.Action ending;

    public float timeRemaining = 60;
    public Text timeText;
    bool disabled = false;
    
    public bool tester = false;
    
    Player player;
    Guard guard;
    
    void Start() {
    
    	player = GameObject.Find("Player").GetComponent<Player>();
    	guard = GameObject.Find("Guard").GetComponent<Guard>();
	}
    
    void Update() {
    	//GameObject[] allGuards = GameObject.FindGameObjectsWithTag("Guard");
    	//foreach(GameObject guards in allGuards)
			//if (Guard.OnGuardHasSpottedPlayer != null) {
				//tester = true;
			//}
    	if (player.tester == true || tester == true){
    		Disable();
    	}

    	if (disabled == true){
    	}
		else if (timeRemaining > 0) {
		    timeRemaining -= Time.deltaTime;
		}
		else{
			timeRemaining = 0;
		}
		
		DisplayTime(timeRemaining);
    }
    
    void DisplayTime(float timeToDisplay) {
		if (timeToDisplay < 0) {
			timeToDisplay = 0;
    			ending ();
		}
		
	  	float minutes = Mathf.FloorToInt(timeToDisplay / 60);  
	  	float seconds = Mathf.FloorToInt(timeToDisplay % 60);
	  	float milliseconds = timeToDisplay % 1 * 1000;

	  	//timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
	  	timeText.text = string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliseconds);
	}
	
	void Disable() {
    	disabled = true;
    }
    
}
