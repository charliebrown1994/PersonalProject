using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDetectionTrigger : MonoBehaviour
{
    private bool isPlayerInRange = false; // bool�� ���� Player�� ������ ��� �Դ��� Ȯ���ϴ� ����

    void Update()
    {
        // ���ǽ����� ��ȣ�ۿ� �ϱ�
        if (isPlayerInRange && Input.GetKeyDown(KeyCode.F))
        {
            // �޼��� ����
            Interact();
        }
    }

    private void Interact()
    {
        Debug.Log("NPC�� ��ȣ�ۿ� ��...");
        SceneManager.LoadScene("TopDownScene");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = false;
        }
    }
}
