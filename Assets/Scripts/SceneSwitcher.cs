using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void SwitchToGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void SwitchToCooperationPage()
    {
        SceneManager.LoadScene("CooperationPage");
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}