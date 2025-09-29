using UnityEngine;

public class LearningCurve1 : MonoBehaviour
{
    public int myInt;
    public float myFloat;
    public string myString;
    public bool myBool;

    // single line comment
    /* multi-line
       comment */
    /// <summary>
    /// This script demonstrates basic variables in Unity
    /// </summary>
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Public variable (visible in Inspector)
    public string playerName = "Tanaka";

    // Private variable (hidden from Inspector)
    private int playerAge = 20;

    // Method
    public void GreetPlayer(string playerName)
    {
        Debug.Log($"Welcome, {playerName}!");
    }
    public int BirthYear(int birthYear)
        {
            return 2025 - birthYear;
        }
    void Start()
    {
        // Debug logging
        Debug.Log("Game started!");
        Debug.Log($"Player: {playerName}, Age: {playerAge}");

        Debug.LogFormat("Player {0} is {1} years old", playerName, playerAge);
        
         // String concatenation
        Debug.Log("Player " + playerName + " is " + playerAge + " years old.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
