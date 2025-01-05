using UnityEngine;

public class DoorScript : MonoBehaviour
{
    [SerializeField] private string keyTag;
    public GameObject door;
    public bool locked;

    private bool _boxCollider2D;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        locked = true;
        door.SetActive(locked);
    }

    // Update is called once per frame
    void Update()
    {
        if (!locked)
        {
            
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(keyTag))
        {
            locked = false;
            door.SetActive(locked);
            other.gameObject.SetActive(locked);
        }
    }
}
