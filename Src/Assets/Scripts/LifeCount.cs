using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LifeCount : MonoBehaviour
{
    public Respawn respawn;
    public int defaulthp;
    public int healthpoints;
    public Text healthtext;

    
    [ContextMenu("Takes_healthpoints")]
    public void decrease_health_points()
    {
        healthpoints--;
        healthtext.text = healthpoints.ToString();
        if (healthpoints <= 0)
        {
            GameOver();
        }
    }
    
    [ContextMenu("Reset_healthpoints")]
    public void reset_health_points()
    {
        healthpoints = defaulthp;
        healthtext.text = healthpoints.ToString();
    }

    public void Start()
    {
        healthtext.text = healthpoints.ToString();
    }

    public void GameOver()
    {
            reset_health_points();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //Aktivni scena
    }
    
}
