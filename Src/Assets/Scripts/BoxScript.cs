using UnityEngine;
public class BoxScript : MonoBehaviour
{
    [SerializeField] private new string name;
    [SerializeField] Rigidbody2D rb;
   public void OnCollisionEnter2D(Collision2D collision)
   {
       if (collision.gameObject.CompareTag(name))
       {
           rb.constraints = RigidbodyConstraints2D.None;
           rb.constraints = RigidbodyConstraints2D.FreezeRotation;
           
           Debug.Log(collision.gameObject.name);
       }
   }

   public void OnCollisionExit2D(Collision2D collision)
   {
       if (collision.gameObject.CompareTag(name))
       {
           rb.constraints = RigidbodyConstraints2D.FreezePositionX;
       }
   }
   

    
}
