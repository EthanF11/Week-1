using UnityEngine;

public class Step2 : MonoBehaviour
{
    string _playerName = "Adventurer";
    int _level = 1;
    float _currentHealth = 75.00f;
    private float _maxHealth = 100.0f;
    bool _isAlive = true;

    float _healthPotion = 10;
    float _damage = 20;

    void Start()
    {
        Debug.Log(_playerName);
        Debug.Log(_level);
        Debug.Log(_isAlive);
        Debug.Log(_currentHealth / _maxHealth);

        Debug.Log(_currentHealth - _damage);
        Debug.Log(_currentHealth / _maxHealth);

        Debug.Log(_currentHealth + _healthPotion);
        Debug.Log(_currentHealth / _maxHealth);

    }
}
/*
    1. Class Definition
    
    This defines a Unity script named Step2 that inherits from MonoBehaviour, allowing it to be attached to a GameObject in Unity.
    public class Step2 : MonoBehaviour
    {
        2. Variables (Fields)

        _playerName: Stores the player’s name ("Adventurer").
        _level: Represents the player’s level (1).
        _currentHealth: Tracks the player's current health (75.00).
        _maxHealth: The maximum possible health (100.0), marked as private so it can only be accessed inside this class.
        _isAlive: A bool (true) that indicates whether the player is alive.
        _healthPotion: Represents the amount of health restored when drinking a potion (10).
        _damage: Represents the amount of health lost when taking damage (20).

        string _playerName = "Adventurer";
        int _level = 1;
        float _currentHealth = 75.00f;
        private float _maxHealth = 100.0f;
        bool _isAlive = true;

        float _healthPotion = 10;
        float _damage = 20;

        3. Start Method

        The Start() method runs once when the GameObject with this script is enabled.
        Debug.Log() prints values to the Unity Console.
        Let's analyze the order of outputs:
        
        void Start()
        {
            Debug.Log(_playerName);
            Debug.Log(_level);
            Debug.Log(_isAlive);
            Debug.Log(_currentHealth / _maxHealth);
    
            Debug.Log(_currentHealth - _damage);
            Debug.Log(_currentHealth / _maxHealth);

            Debug.Log(_currentHealth + _healthPotion);
            Debug.Log(_currentHealth / _maxHealth);
        }


    }
        Important Observations
        The health doesn't actually change.
        _currentHealth - _damage and _currentHealth + _healthPotion are just calculations; they don't modify _currentHealth.
        If you want _currentHealth to update, you need to assign the new value:
        Health percentage stays at 0.75 because _currentHealth is never updated.
        Operations like _currentHealth - _damage don't modify _currentHealth unless you store the result.
        Debug.Log() just prints values; it does not modify variables.
 
*/