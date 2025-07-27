using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDetectionTrigger : MonoBehaviour
{
    private bool isPlayerInRange = false; // bool값 선언 Player가 번위에 들어 왔는지 확인하는 변수
    public GameObject interactionHintUI;

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
        SceneManager.LoadScene("TopDownScene");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = true;

            if (interactionHintUI != null)
                interactionHintUI.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = false;

            if (interactionHintUI != null)
                interactionHintUI.SetActive(false);
        }
    }
}
