using UnityEngine;

public class GameManager : MonoBehaviour
{
    public void GameOver()
    {
        
        Debug.Log("Game Over!");
        
        Application.Quit();

        
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; 
#endif
    }

    public void WinGame()
    {
        
        Debug.Log("You Win!");
        
        Application.Quit();

        
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; 
#endif
    }
}

