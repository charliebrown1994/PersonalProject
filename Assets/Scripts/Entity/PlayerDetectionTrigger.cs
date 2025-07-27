using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetectionTrigger : MonoBehaviour
{
    private bool isPlayerInRange = false; // bool값 선언 Player가 번위에 들어 왔는지 확인하는 변수

    void Update()
    {
        // 조건식으로 상호작용 하기
        if (isPlayerInRange && Input.GetKeyDown(KeyCode.F))
        {
            // 메서드 실행
            Interact();
        }
    }

    private void Interact()
    {
        Debug.Log("NPC와 상호작용 중...");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = true;
            Debug.Log("상호작용 가능: E키를 눌러보세요.");
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = false;
            Debug.Log("NPC로부터 멀어짐.");
        }
    }
}
