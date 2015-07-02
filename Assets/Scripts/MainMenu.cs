using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainMenu : MonoBehaviour
{
    Canvas mainMenu;
    Text titleText;
    Text instructionText;

    // Use this for initialization
    void Start()
    {
        mainMenu = gameObject.GetComponent("MainMenuCanvas") as Canvas;
        instructionText = (Text)GameObject.Find("Instructions").GetComponent(typeof(Text));
        titleText = (Text)GameObject.Find("Title").GetComponent(typeof(Text));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            Application.Quit();
        }
        else if (Input.anyKey)
        {
            Application.LoadLevel("game");
        }
    }
}
