using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 5; 
    public int currentHealth; 
    public GameManager gameManager;
    void Start()
    {
        
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        
        currentHealth -= damage;

        
        if (currentHealth <= 0)
        {
            gameManager.GameOver();
        }
    }

    public void Heal(int healAmount)
    {
        
        currentHealth += healAmount;

        
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }

    
}

