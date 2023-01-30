using UnityEngine;
using UnityEngine.SceneManagement;
public class gamemanager : MonoBehaviour
{
    public float delay = 1f;

    public GameObject completelevelui;

    public void completelevel()
    {
        completelevelui.SetActive(true);
    }

    bool gamehasended = false;
    public void endgame()
    {
        if (gamehasended  ==  false)
        {
            gamehasended = true;
            Debug.Log("Game Over");
            Invoke("Restart", delay );

        }
        
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }


 
}
