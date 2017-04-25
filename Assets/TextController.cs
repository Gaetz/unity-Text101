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
                StateMirror(); break;
            case States.sheets_0:
                StateSheets0(); break;
            case States.lock_0:
                StateLock0(); break;
            case States.cell_mirror:
                StateCellMirror(); break;
            case States.sheets_1:
                StateSheets1(); break;
            case States.lock_1:
                StateLock1(); break;
            case States.freedom:
                StateFreedom(); break;
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
        else if (Input.GetKeyDown(KeyCode.M))
        {
            currentState = States.mirror;
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            currentState = States.lock_0;
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

    void StateMirror()
    {
        text.text = "The dirty old mirror on the wall seems loose.\n\n" +
            "Press T to Take the mirror\n"+
            "Press R to Return\n";
        if (Input.GetKeyDown(KeyCode.R))
        {
            currentState = States.cell;
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            currentState = States.cell_mirror;
        }
    }

    void StateLock0()
    {
        text.text = "This is one of those button locks. You have no idea what the " +
            "combinaison is. You wish you could somehow see where the dirty " +
            "firgerprints were. Maybe that would help.\n\n" +
            "Press R to Return roaming your cell.\n";
        if (Input.GetKeyDown(KeyCode.R))
        {
            currentState = States.cell;
        }
    }

    void StateCellMirror()
    {
        text.text = "You are still in your cell and STILL want to escape. There are " +
            "some dirty sheets on the bed, a mark where the mirror was," +
            "and that pesky door is still there, and firmly locked.\n\n" +
            "Press S to view Sheets\n" +
            "Press L to look at the Lock\n";
        if (Input.GetKeyDown(KeyCode.S))
        {
            currentState = States.sheets_1;
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            currentState = States.lock_1;
        }
    }

    void StateSheets1()
    {
        text.text = "Holding a mirror in your hand doesn't make the sheets look " +
            "any better.\n\n" +
            "Press R to Return\n";
        if (Input.GetKeyDown(KeyCode.R))
        {
            currentState = States.cell_mirror;
        }
    }

    void StateLock1()
    {
        text.text = "You carefully but your mirror through the bars, and turn it around " +
            "so you can see the lock. You canjust make out fingerprints around " +
            "the buttons. You press dirty buttons, and hear the click.\n\n" +
            "Press O to Open\n"+
            "Press R to Return\n";
        if (Input.GetKeyDown(KeyCode.O))
        {
            currentState = States.freedom;
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            currentState = States.cell_mirror;
        }
    }

    void StateFreedom()
    {
        text.text = "You are FREE !\n\n" +
            "Press P to Play again\n";
        if (Input.GetKeyDown(KeyCode.P))
        {
            currentState = States.cell;
        }
    }
}
