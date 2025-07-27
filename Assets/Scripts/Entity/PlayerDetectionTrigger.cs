using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = true;
            Debug.Log("��ȣ�ۿ� ����: EŰ�� ����������.");
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = false;
            Debug.Log("NPC�κ��� �־���.");
        }
    }
}
