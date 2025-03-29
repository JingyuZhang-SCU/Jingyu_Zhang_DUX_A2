using UnityEngine;
using UnityEngine.UI;

public class ReturnButton : MonoBehaviour
{
    public SceneLoader sceneLoader;

    private void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        if (sceneLoader != null)
        {
            sceneLoader.LoadScene("MainMenuScene");
        }
    }
}