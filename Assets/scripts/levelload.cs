using UnityEngine;
using UnityEngine.SceneManagement;
public class levelload : MonoBehaviour
{
   public void Loadnextlevel ()
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1 );
   }
}
