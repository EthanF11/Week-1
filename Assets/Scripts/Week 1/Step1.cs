using UnityEngine;

public class Step1 : MonoBehaviour
{
    string _playerName = "Adventurer";
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
