using UnityEngine;
using UnityEngine.SceneManagement;
public class EventScript : MonoBehaviour
{
    public GameObject PM;
    public GameObject helpMenu;
    public bool isPaused;

    private bool isHelp;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isHelp = false;
        PM.SetActive(false);
        isPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)ResumeGame();
            else PauseGame();
        }

        if (Input.GetKey(KeyCode.F1))
        {
            helpMenu.SetActive(true);
            isHelp = true;
        }

        if (Input.GetKeyUp(KeyCode.F1))
        {
            isHelp = false;
        }
        else if (helpMenu.activeInHierarchy && !isHelp)
        {
            helpMenu.SetActive(false);
        }
    }

    public void PauseGame()
    {
        PM.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void ResumeGame()
    {
        PM.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void toTheMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void ResetLevel()
    {
        SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex).ToString());
    }

    public void HelpMenu()
    {
        isHelp = !isHelp;
        helpMenu.SetActive(true);
    }
}
