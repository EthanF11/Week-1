using UnityEngine;

public class Step3 : MonoBehaviour
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

        //_currentHealth = _currentHealth - _damage;
        _currentHealth -= _damage; 
        Debug.Log(_currentHealth / _maxHealth);

       // _currentHealth = _currentHealth + _healthPotion;
        _currentHealth += _healthPotion;
        Debug.Log(_currentHealth / _maxHealth);

    }
}
/*
  1. Class Definition

    This is a Unity script named Step3 that inherits from MonoBehaviour, meaning it can be attached to a GameObject.

    public class Step3 : MonoBehaviour
    {
        2. Variables (Fields)

        _playerName: Stores the player�s name ("Adventurer").
        _level: Represents the player�s level (1).
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
        Prints the player's name, level, alive status, and current health percentage (_currentHealth / _maxHealth).
        
        void Start()
        {
            Debug.Log(_playerName);
            Debug.Log(_level);
            Debug.Log(_isAlive);
            Debug.Log(_currentHealth / _maxHealth);

            Unlike in Step2, _currentHealth is actually being modified and stored.

            _currentHealth -= _damage; is just a shorter way to write _currentHealth = _currentHealth - _damage;.

            //_currentHealth = _currentHealth - _damage;
            _currentHealth -= _damage;
            Debug.Log(_currentHealth / _maxHealth);

            _currentHealth += _healthPotion; is just a shorter way to write _currentHealth = _currentHealth + _healthPotion;.

            //_currentHealth = _currentHealth + _healthPotion;
            _currentHealth += _healthPotion;
            Debug.Log(_currentHealth / _maxHealth);
        }
    }
 
 */