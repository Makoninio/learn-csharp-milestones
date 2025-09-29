using UnityEngine;

public class Character : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public string name;
    public int number;

    // Constructor
    public Character(string name, int number)
    {
        this.name = name;
        this.number = number;
    }

    public struct Weapon
    {
        public string name;
        public int damage;

        // Constructor
        public Weapon(string name, int damage)
        {
            this.name = name;
            this.damage = damage;
        }
    }

    public class Paladin : Character
    {
        public Weapon weapon;

        // Constructor calls base Character constructor
        public Paladin(string name, int level, Weapon weapon) : base(name, level)
        {
            this.weapon = weapon;
        }
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
