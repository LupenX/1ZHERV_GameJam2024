using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject White;
    public GameObject Black;

    public float jumpPower;
    public float mSpeed;

    private float horizontal;
    private bool toggle;
    public Rigidbody2D rbW;
    public Rigidbody2D rbB;
    [SerializeField] private Transform groundCheckW;
    [SerializeField] private Transform groundCheckB;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private LayerMask jumpLayer;
    private bool _isFacingRight = true;
    void Start()
    {
        rbW = White.GetComponent<Rigidbody2D>();
        rbB = Black.GetComponent<Rigidbody2D>();
        toggle = true; //White = True; Black = False
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        Flip(); 
        if (Input.GetKeyDown(KeyCode.G))
        {
            toggle = !toggle;
        }

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            if (toggle)
            {
                
                if (Physics2D.OverlapCircle(groundCheckW.position, 0.2f, jumpLayer))
                {
                    rbW.linearVelocity = new Vector2(rbW.linearVelocity.x, jumpPower * 1f);
                }
                else
                {
                    rbW.linearVelocity = new Vector2(rbW.linearVelocity.x, jumpPower * 0.5f);
                }
            }
            else
            {
                if (Physics2D.OverlapCircle(groundCheckB.position, 0.2f, jumpLayer))
                {
                    rbB.linearVelocity = new Vector2(rbB.linearVelocity.x, jumpPower * 1f);
                }
                else
                {
                    rbB.linearVelocity = new Vector2(rbB.linearVelocity.x, jumpPower * 0.5f);
                }
            }
        }

        
    }

    private void FixedUpdate()
    {
        if (toggle)
        {
            if (rbW) rbW.linearVelocity = new Vector2(horizontal * mSpeed, rbW.linearVelocity.y);
        }
        else
        {
            if (rbB) rbB.linearVelocity = new Vector2(horizontal * mSpeed, rbB.linearVelocity.y);
        }
    }

    private void Flip()
    {
        if (_isFacingRight && horizontal < 0f || !_isFacingRight && horizontal > 0f)
        {
            _isFacingRight = !_isFacingRight;
            Vector3 theScale = transform.localScale;
            theScale.x *= -1f;
            transform.localScale = theScale;
        }
    }

    private bool IsGrounded()
    {
        if (toggle)
        {
            if(groundCheckW) return Physics2D.OverlapCircle(groundCheckW.position,0.2f,groundLayer);
            if(groundCheckW) return Physics2D.OverlapCircle(groundCheckW.position,0.2f,jumpLayer);
        }
        else
        {
            if(groundCheckB) return Physics2D.OverlapCircle(groundCheckB.position,0.2f,groundLayer);
            if(groundCheckB) return Physics2D.OverlapCircle(groundCheckB.position,0.2f,jumpLayer);
        }

        return false;
    }
}

