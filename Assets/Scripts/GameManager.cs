using UnityEngine;
using UnityEngine.UI;
using System.Collections;

enum GamePhase {Fortify, Build, Defend}

public class GameManager : MonoBehaviour
{
  Canvas gameUICanvas;
  Text phaseText;
  Text instructionText;
  Camera camera;
  int currentPhase = 0;

    // Use this for initialization
    void Start()
    {
      gameUICanvas = gameObject.GetComponent("GameUICanvas") as Canvas;
      instructionText = (Text)GameObject.Find("Instructions").GetComponent(typeof(Text));
      phaseText = (Text)GameObject.Find("Phase").GetComponent(typeof(Text));
      Cursor.visible = true;
      camera = GetComponent<Camera>();
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

        if(GamePhase.Fortify == (GamePhase)currentPhase && Input.GetMouseButtonDown(0)){

                    GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    Vector3 worldLoc = camera.ScreenToWorldPoint(new Vector3 (Input.mousePosition.x,Input.mousePosition.y,Input.mousePosition.z));
                    worldLoc.z = 0;
                    print("Position " + worldLoc.x + ", " + worldLoc.y + ", " + worldLoc.z);
                    cube.transform.position = worldLoc;
        }
    }
}
