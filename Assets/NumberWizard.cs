using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int min = 1;
    int max = 1001;
    int guess;

    void updateGuess()
    {
        guess = (min + max) / 2;
    }
    // Start is called before the first frame update
    void Start()
    {

        updateGuess();
        Debug.Log("Welcome to the Number Wizard !");
        Debug.Log("I am going to guess the muber you pick in mind.");
        Debug.Log("The Minimum number to pick : " + min);
        Debug.Log("The Maximum number to pick : " + max);

        Debug.Log("If your number is Higher press UpArrow, If your Number is Lower press DownArrow, Else press Enter.");
        Debug.Log("Is your guess : " + guess);
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("UpArrow has been pressed. ");
            min = guess;
            updateGuess();
            Debug.Log("Is your guess : " + guess);
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("DownKey has been pressed.");
            max = guess;
            updateGuess();
            Debug.Log("Is your guess : " + guess);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("ReturnKey has been pressed.");
        }
    }
}
