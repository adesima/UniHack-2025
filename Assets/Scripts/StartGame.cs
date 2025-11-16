using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
   
    [SerializeField] private string gameSceneName;
    public void StartLevel()
    {
        SceneManager.LoadScene(gameSceneName);
    }
}
