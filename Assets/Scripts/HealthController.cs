using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    [SerializeField] float MaxHealth = 100;

    private float _currentHealth;

    private HealthBar _HealthBar;

    [SerializeField] MyAdvancedGUI _myAdvancedGUI;

    public float CurrentHealth { get => _currentHealth; }

    void Start()
    {
        _currentHealth = MaxHealth;
        _HealthBar = GetComponent<HealthBar>();
    }

    public void GetDamage(float damage)
    {
        _currentHealth -= damage;

        _HealthBar.SetHealth((int)_currentHealth);
        _myAdvancedGUI.SetHP(_currentHealth);

        if (CurrentHealth <= 0)
        {
            Debug.Log("Game Over");
        }
    }
}