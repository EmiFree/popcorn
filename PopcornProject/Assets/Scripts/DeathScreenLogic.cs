using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreenLogic : MonoBehaviour
{
    public void RestartGame() { SceneManager.LoadScene("MainMenu"); }
}
