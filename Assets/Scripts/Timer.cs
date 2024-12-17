using UnityEngine;
using UnityEngine.UI;  // ���� ������ ���������� ����� �� UI

public class Timer : MonoBehaviour
{
    public Text timerText;  // ������ �� UI ������� ��� ����������� �������
    private float timeElapsed = 0f;
    private bool isTiming = false;

    public float recordedTime = 0f;  // ���������� ��� ���������� �������, ���������� �� ����� � �������

    // ����� ��� ������ ������� �������
    public void StartTimer()
    {
        isTiming = true;
        timeElapsed = 0f;
    }

    // ����� ��� ��������� �����������
    public void StopTimer()
    {
        isTiming = false;
    }

    // ����� ��� ������ �������
    public void ResetTimer()
    {
        timeElapsed = 0f;
    }

    // ��������� ����� ��� ��������� �������
    public float GetTimeElapsed()
    {
        return timeElapsed;
    }

    // ����� ��� ���������� ������� ������ ����
    void Update()
    {
        if (isTiming)
        {
            timeElapsed += Time.deltaTime;  // ����������� ����� �� �����, ��������� � ���������� �����
            timerText.text = "Time: " + timeElapsed.ToString("F2");  // ��������� ����� UI
        }
    }

    // ������ ������ ������� ��� ������ ����
    void Start()
    {
        StartTimer();  // �������� ������ ������� ����� ��� ������ ����
    }
}
