using UnityEngine;
using UnityEngine.UI;  // ��� ������ � UI Text

public class LevelTrigger : MonoBehaviour
{
    public Timer timer;  // ������ �� ������ �����������
    public Text timeDisplay;  // ������ �� UI Text ��� ����������� �������

    // �������� �� ���� � �������
    private void OnTriggerEnter2D(Collider2D other)
    {
        // ��������, ��� � ������� ����� ������ � ����� "Player"
        if (other.CompareTag("Player"))
        {
            // ���������� �����, ������� ������ �� ����� � �������
            timer.recordedTime = timer.GetTimeElapsed();
            Debug.Log("����� �����: " + timer.recordedTime + " ���");

            // ��������� ��������� ���� � ����������� ��������
            timeDisplay.text = "����� �����: " + timer.recordedTime.ToString("F2") + " ���";

            timer.ResetTimer();  // ���������� ������
        }
    }
}
