using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public GameManager gameManager; 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player"))
        {
            gameManager.WinGame(); 
        }
    }
}

