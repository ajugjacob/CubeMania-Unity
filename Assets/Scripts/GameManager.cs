using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool hasGameEnded = false;
    public float endGameDelay = 2f;
    public GameObject completeLevelUI;



    public void Completed()
    {
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (hasGameEnded == false)
        {
            Debug.Log("Game Has Ended");
            hasGameEnded = true;
            Invoke("Restart", endGameDelay);
        }
        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
