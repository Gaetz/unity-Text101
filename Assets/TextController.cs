using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

    /// <summary>
    /// Text displayed in game
    /// </summary>
    public Text text;

    /// <summary>
    /// Game states
    /// </summary>
    enum States { cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, freedom };

    /// <summary>
    /// Current game state
    /// </summary>
    States currentState;

    // Use this for initialization
	void Start ()
    {
        currentState = States.cell;
	}
	
	// Update is called once per frame
	void Update ()
    {
        switch(currentState)
        {
            case States.cell:
                StateCell(); break;
            case States.mirror:
                StateCell(); break;
            case States.sheets_0:
                StateSheets0(); break;
            case States.lock_0:
                StateCell(); break;
            case States.cell_mirror:
                StateCell(); break;
            case States.sheets_1:
                StateCell(); break;
            case States.lock_1:
                StateCell(); break;
            case States.freedom:
                StateCell(); break;
        }
    }

    void StateCell()
    {
        text.text = "You are in a prison cell, and you want to escape. There are " +
            "some dirty sheets on the bed, a mirror on the wall, and the door " +
            "is locked from the outside.\n\n" +
            "Press S to view Sheets\n" +
            "Press M to look at the Mirror\n" +
            "Press L to look at the Lock\n";
        if (Input.GetKeyDown(KeyCode.S))
        {
            currentState = States.sheets_0;
        }
    }

    void StateSheets0()
    {
        text.text = "You can't believe you sleep in these things. Surely it's " +
            "time somebody change them. The pleasurs of prison life " +
            "you guess !\n\n" +
            "Press R to Return\n";
        if (Input.GetKeyDown(KeyCode.R))
        {
            currentState = States.cell;
        }
    }
}
