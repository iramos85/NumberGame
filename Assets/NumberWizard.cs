using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
        int maxGuess = 1000;
        int minGuess = 1;
        int guess = 500;
   
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        maxGuess = 1000;
        minGuess = 1;
        guess = 500;

        Debug.Log("*****Welcome to Number Wizard****");
        Debug.Log("Pick a number");
        Debug.Log("The highest number is: " + maxGuess);
        Debug.Log("The lowest number is: " + minGuess);
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        
        maxGuess = maxGuess + 1;
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            minGuess = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            maxGuess = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("YES. I AM A GENIUS!");
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (maxGuess + minGuess) / 2;
        Debug.Log("Is it higher or lower than " + guess + "?");
    }
}
