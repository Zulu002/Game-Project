using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jumpForce = 10f; // ���� ������
    public Transform groundCheck; // ����� �������� �����
    public LayerMask groundLayer; // ���� �����
    private Rigidbody2D rb;
    private bool isGrounded;
    public Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // ���������, ��������� �� �������� �� �����
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);

        // ��������� �������� �������� Jumping � ���������
        animator.SetBool("Jumping", !isGrounded); // ������: ����� �� �� �����, �������� ��������

        // ������
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            // ������: ������������� �������� �� ��� Y ��� ���������� ������
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);

            // ��������� ���� ��� �������, ���� ����� (��������, ��������� ������)
        }
    }
}
