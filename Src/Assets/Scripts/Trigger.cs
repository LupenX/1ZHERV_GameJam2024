using UnityEngine;

public class Trigger : MonoBehaviour
{
    public bool isObstacle;
    public bool isWhite;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public LifeCount logic;
    public Respawn respawn;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LifeCount>();
    }
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("WChar") && !isWhite)
        {
            logic.decrease_health_points(); 
            respawn.Die();
        }
        
        
        else if (collision.gameObject.CompareTag("BChar") && isWhite)
        {
            logic.decrease_health_points();
            respawn.Die();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isObstacle)
        {
            Debug.Log("Obstacle");
            if (collision.gameObject.CompareTag("WChar") || collision.gameObject.CompareTag("BChar"))
            {
                Debug.Log("Obstacle kill");
                logic.decrease_health_points(); 
                respawn.Die();
            }
        }
    }
}

