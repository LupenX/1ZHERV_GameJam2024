using UnityEngine;
using UnityEngine.SceneManagement;
public class EndScript : MonoBehaviour
{
    public LifeCount lifeCount;
    public Respawn respawn;
    [SerializeField]private int charNumber = 2;
    [SerializeField]private string lvlName;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
  

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        charNumber--;
        if (charNumber == 0)
        {
            SceneManager.LoadScene(lvlName); //Aktivni scena potom dat inc
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        charNumber++;
    }
}
