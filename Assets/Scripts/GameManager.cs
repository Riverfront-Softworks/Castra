using UnityEngine;
using UnityEngine.UI;
using System.Collections;

enum GamePhase {Fortify, Build, Defend}

public class GameManager : MonoBehaviour
{
  Canvas gameUICanvas;
  Text phaseText;
  Text instructionText;
  int currentPhase = 0;


    // Use this for initialization
    void Start()
    {
      gameUICanvas = gameObject.GetComponent("GameUICanvas") as Canvas;
      instructionText = (Text)GameObject.Find("Instructions").GetComponent(typeof(Text));
      phaseText = (Text)GameObject.Find("Phase").GetComponent(typeof(Text));
      Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("escape"))
        {
            Application.LoadLevel("mainMenu");
        }
        else if(Input.GetKeyUp("space"))
        {
            currentPhase = (currentPhase + 1) % 3;
            phaseText.text = "Phase: " + (GamePhase)currentPhase;
        }
    }
}
