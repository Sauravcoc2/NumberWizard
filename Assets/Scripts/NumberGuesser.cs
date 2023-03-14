using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberGuesser : MonoBehaviour
{
    [SerializeField] int max = 1000;
    [SerializeField] int min = 1;
    [SerializeField] TextMeshProUGUI guessText;

    int guess;
    
    public void Start()
    {
        StartGame();
    }

    public void StartGame()
    {
        nextGuess();
        max = max + 1;
    }

    public void nextGuess()
    {
        guess = Random.Range(min, max);
        guessText.text = guess.ToString();
    }

    public void OnPressHigher()
    {
        min = guess;
        nextGuess();
    }

    public void OnPressLower()
    {
        max = guess;
        nextGuess();
    }    
}
