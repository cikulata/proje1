using UnityEngine;

public class Door : MonoBehaviour
{
    public bool isUnlocked = false; 

    void Update()
    {
        
        if (isUnlocked)
        {
            Destroy(gameObject); 
        }
    }
}

