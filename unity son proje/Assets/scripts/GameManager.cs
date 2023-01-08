
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int win_number;

    void Update() {
        if (win_number ==2)
        {
            SceneManager.LoadScene("WinGame");
            
        }
    }

    public void Level1()
    {
        SceneManager.LoadScene("level1");
    }
    public void Level2()
    {
        SceneManager.LoadScene("level2");
    }
    public void Exit()
    {
        SceneManager.LoadScene("StartMenu");
    }

}
