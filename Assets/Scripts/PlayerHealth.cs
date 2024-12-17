using UnityEngine;
using UnityEngine.SceneManagement; // ���������� SceneManager

public class PlayerHealth : MonoBehaviour
{
    public Animator animator; // �������� ��� �������� ������
    public int maxLives = 3; // ������������ ���������� ������
    private int currentLives; // ������� ���������� ������

    void Start()
    {
        // ������������� ��������� ���������� ������
        currentLives = maxLives;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // ���������, ����� �� �������� � ������ � ����� "Hazard"
        if (collision.gameObject.CompareTag("Hazard"))
        {
            TakeDamage(); // ��������� ���������� ������
        }
    }

    private void TakeDamage()
    {
        currentLives--; // ��������� ����� �� 1
        Debug.Log($"Player hit! Lives remaining: {currentLives}");

        if (currentLives <= 0)
        {
            Die(); // ���� ����� �����������, �������� ������
        }
        else
        {
            // ����������� �������� "�������" (�����������)
            if (animator != null)
            {
                //animator.SetTrigger("Hurt");
            }
        }
    }

    private void Die()
    {
        Debug.Log("Player Died");

        // ����������� �������� ������
        if (animator != null)
        {
            animator.SetTrigger("Death");
        }

        // ��������� ���������� ����������
        GetComponent<PlayerMovement>().enabled = false;
        GetComponent<PlayerJump>().enabled = false;

        // ������������� ������� ����� 2 �������
        Invoke("RestartLevel", 2f);
    }

    private void RestartLevel()
    {
        // ������������� ������� �����
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void AddLife()
    {
        // ����������� ���������� ������, �� �� ��������� ��������
        if (currentLives < maxLives)
        {
            currentLives++;
            Debug.Log($"Life added! Current lives: {currentLives}");
        }
    }
}
