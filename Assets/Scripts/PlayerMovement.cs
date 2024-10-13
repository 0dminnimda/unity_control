using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float gravity = 9.81f;
    public float speed = 10f;
    public float jumpHeight = 1f;

    public LayerMask groundMask;
    public Transform groundCheck;
    public float radiusOfCheck = 0.5f;

    private CharacterController controller;

    private Vector3 velocity;
    private bool isGrounded;
    
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, radiusOfCheck, groundMask);

        if (isGrounded && velocity.y < 0f)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump"))
        {
            velocity.y = Mathf.Sqrt(jumpHeight * 2f * gravity);
        }

        velocity.y -= gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}
