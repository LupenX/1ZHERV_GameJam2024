using UnityEngine;

public class ButtonScript : MonoBehaviour
{   
    private string tagColor;
    private string tagChar;
    [SerializeField] private bool isWhite;
    [SerializeField] public GameObject triggeredObject;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (isWhite)
        {
            tagChar = "WChar";
            tagColor = "White";
        }
        else
        {
            tagChar = "BChar";
            tagColor = "Black";
        }
    }

    // Update is called once per frame
    void Update()
    {
            
    }

    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(tagChar) || other.gameObject.CompareTag(tagColor))
        { 
            triggeredObject.SetActive(false);
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(tagColor) || other.gameObject.CompareTag(tagChar))
        { 
            triggeredObject.SetActive(true);
        }
    }
}
