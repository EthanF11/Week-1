using UnityEngine;

public class Step1 : MonoBehaviour
{
    public string _playerName = "Adventurer";
    int _level = 1;
    float _currentHealth = 75.00f;
    private float _maxHealth = 100.0f;
    bool _isAlive = true;

    void Start()
    {
        Debug.Log(_playerName); 
        Debug.Log(_level);
        Debug.Log(_currentHealth / _maxHealth);
        Debug.Log(_isAlive);
    }
}
/*
    1. Class Definition

    This defines a class called Step1, which inherits from MonoBehaviour.
    MonoBehaviour is the base class that allows scripts to be attached to GameObjects in Unity.
    
    public class Step1 : MonoBehaviour
    {
        2. Variables (Fields)

        These are fields that store data about the player.

        _playerName: Stores the name of the player as a string ("Adventurer").
        _level: An integer (int) representing the player's level (1).
        _currentHealth: A float representing the player’s current health (75.00f).
        _maxHealth: A private float representing the maximum health (100.0f).
        _isAlive: A boolean that tracks whether the player is alive (true).

        string _playerName = "Adventurer";
        int _level = 1;
        float _currentHealth = 75.00f;
        private float _maxHealth = 100.0f;
        bool _isAlive = true;

        3. Start Method

        The Start() method runs once when the script starts (when the GameObject is first enabled in Unity).
        Debug.Log() is used to print messages to the Unity Console for debugging.
        This prints:
        The _playerName ("Adventurer").
        The _level (1).
        The health percentage (_currentHealth / _maxHealth = 75.00 / 100.00 = 0.75).
        The _isAlive status (true).

        void Start()
        {
            Debug.Log(_playerName); 
            Debug.Log(_level);
            Debug.Log(_currentHealth / _maxHealth);
            Debug.Log(_isAlive);
        }

    }

*/