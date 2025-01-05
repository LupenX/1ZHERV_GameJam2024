using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject wChar;
    public GameObject bChar;
    public GameObject spawnpoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   
    
    public void Die()
    {
        wChar.transform.position = spawnpoint.transform.position;
        bChar.transform.position = spawnpoint.transform.position;

        wChar.GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;
        bChar.GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;
    }
}
