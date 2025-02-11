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
