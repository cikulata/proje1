using UnityEngine;

public class Key : MonoBehaviour
{
    public Door door; 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player"))
        {
            door.isUnlocked = true; 
            Destroy(gameObject); 
        }
    }
}

