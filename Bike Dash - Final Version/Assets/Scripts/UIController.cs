using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public void PlayGame()
    {
        // Replace "SampleScene" with your game scene name
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitGame()
    {
        // Quit the application
        Application.Quit();
    }
}
