using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenScenePlay : MonoBehaviour
{
    public string sceneToOpen;

    public void OpenScene()
    {
       SceneManager.LoadScene(sceneToOpen);
    }
}
