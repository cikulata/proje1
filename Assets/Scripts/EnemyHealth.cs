using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxEnemyHealth = 3;  
    private int currentEnemyHealth;  

    void Start()
    {
        
        currentEnemyHealth = maxEnemyHealth;
    }

    
    public void TakeDamag(int damage)
    {
        currentEnemyHealth -= damage; 

        
        if (currentEnemyHealth <= 0)
        {
            Diee();
        }
    }

    
    void Diee()
    {
        
        Debug.Log($"{gameObject.name} has died!");

        
        Destroy(gameObject);
    }
}


