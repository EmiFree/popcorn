using UnityEngine;

public class QuitButtonLogic : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Bye Bye");
    }
}
