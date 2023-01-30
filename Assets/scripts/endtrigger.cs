using UnityEngine;

public class endtrigger : MonoBehaviour
{
    public gamemanager Gamemanager;
    void OnTriggerEnter()
    {
        Gamemanager.completelevel();
    }

}
