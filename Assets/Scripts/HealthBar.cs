using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider healthSlider; 
    public PlayerHealth playerHealth; 

    void Update()
    {
        
        healthSlider.value = (float)playerHealth.currentHealth / playerHealth.maxHealth;
    }
}

