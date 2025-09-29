using UnityEngine;
using System.Collections.Generic;

public class Chapter4 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Write if, else if, and else statements
        int health = 50;

        if (health > 75)
        {
            Debug.Log("You are in great shape!");
        }
        else if (health > 25)
        {
            Debug.Log("You are hanging in there.");
        }
        else
        {
            Debug.Log("Warning: Critical health!");
        }

        // Test for true and !true in a conditional
        bool hasKey = true;
        if (hasKey)
        {
            Debug.Log("You can open the treasure chest!");
        }
        if (!hasKey)
        {
            Debug.Log("The chest remains locked...");
        }

        // Nested if statements
        bool hasWeapon = true;
        bool hasAmmo = false;
        if (hasWeapon)
        {
            if (hasAmmo)
            {
                Debug.Log("Ready to fight!");
            }
            else
            {
                Debug.Log("You need more ammo!");
            }
        }

        //Switch statement
        string day = "Monday";

        switch (day)
        {
            case "Monday":
                Debug.Log("Start of the week grind.");
                break;
            case "Friday":
                Debug.Log("Almost the weekend!");
                break;
            default:
                Debug.Log("Just another day...");
                break;
        }

        // Arrays
        string[] words = { "ball", "food", "house", "car" };
        Debug.Log($"I eat: {words[1]}");

        int[] scores = { 10, 20, 30, 40 };
        List<string> players = new List<string>() { "Alice", "Bob", "Charlie" };

        Dictionary<string, int> inventory = new Dictionary<string, int>()
        {
            { "Potion", 3 },
            { "Sword", 1 },
            { "Shield", 1 }
        };

        //Loops
        for (int i = 0; i < players.Count; i++)
        {
            Debug.Log($"Player {i}: {players[i]}");
        }

        foreach (string player in players)
        {
            Debug.Log($"Player: {player}");
        }

        foreach (KeyValuePair<string, int> item in inventory)
        {
            Debug.Log($"{item.Key}: {item.Value}");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
