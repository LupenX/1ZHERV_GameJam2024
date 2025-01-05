using UnityEngine;

public class KeyScript : MonoBehaviour
{
    [SerializeField] private GameObject character;
    [SerializeField] private string chartag;
    public bool isPickedUp;
    private Vector2 velocity;
    public float smoothTime = 0.3f;
    private void Update()
    {
        if (isPickedUp)
        {
            Vector3 offset = new Vector3(0, 1, 0);
            transform.position = Vector2.SmoothDamp(transform.position, character.transform.position + offset, ref velocity, smoothTime);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(chartag) && !isPickedUp)
        {
            isPickedUp = true;
        }
    }
}
