using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField] private int _nextLevel;
    [SerializeField] private int _currentLevel;

    public void NextLevel()
    {
        SceneManager.LoadScene(_nextLevel);
    }

    public void Restart()
    {
        SceneManager.LoadScene(_currentLevel);
    }
}
