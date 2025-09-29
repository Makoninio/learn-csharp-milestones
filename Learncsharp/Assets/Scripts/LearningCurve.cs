using UnityEngine;

public class LearningCurve1 : MonoBehaviour
{

    void Start()
    {
        Character hero = new Character("Artemis", 10);
        Character heroine = new Character("Athena", 12);

        Debug.Log($"Character: {hero.name}, Level: {hero.number}");
        Debug.Log($"Character: {heroine.name}, Level: {heroine.number}");

        // Structs (Weapon is nested inside Character)
        Character.Weapon huntingBow = new Character.Weapon("Hunting Bow", 25);
        Character.Weapon warBow = new Character.Weapon("War Bow", 40);

        Debug.Log($"Weapon: {huntingBow.name}, Damage: {huntingBow.damage}");
        Debug.Log($"Weapon: {warBow.name}, Damage: {warBow.damage}");

        // Paladin is a nested class inside Character, so reference it as Character.Paladin
        Character.Paladin knight = new Character.Paladin("Lancelot", 20, warBow);
        Debug.Log($"Paladin: {knight.name}, Level: {knight.number}, Weapon: {knight.weapon.name}, Damage: {knight.weapon.damage}");

        // Get Main Camera Transform
        Transform cameraTransform = GetComponent<Transform>();
        Debug.Log($"Main Camera Position: {cameraTransform.localPosition}");

        // Find Light GameObject
        GameObject lightObj = GameObject.Find("Directional Light");
        if (lightObj != null)
        {
            Transform lightTransform = lightObj.GetComponent<Transform>();
            Debug.Log($"Light Position: {lightTransform.localPosition}");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
