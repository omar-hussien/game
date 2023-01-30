using UnityEngine;
using UnityEngine.SceneManagement;
public class gameManager : MonoBehaviour
{
    bool gamehasended = false;
    
    public void EndGame()
    {
        if (gamehasended  ==  false)
        {
            gamehasended = true;
            Debug.Log("Game Over");
            restart();
        }
        
    }
    void restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

 
}
