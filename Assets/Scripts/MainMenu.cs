using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainMenu : MonoBehaviour {
    Canvas mainMenu;
    Text title;
    Text instruction;

	// Use this for initialization
	void Start () {
        mainMenu = gameObject.GetComponent("MainMenuCanvas") as Canvas;
        instruction = (Text)GameObject.Find("Instructions").GetComponent(typeof(Text));
        instruction = (Text)GameObject.Find("Title").GetComponent(typeof(Text));
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.anyKey && !(Input.GetKeyUp("escape"))){
            instruction.text = "Press 'Esc' to quit!";   
        }
	}
}
