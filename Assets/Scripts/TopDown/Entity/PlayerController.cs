using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace MiniGame.TopDown
{
public class PlayerController : BaseController
{
    //private new Camera camera;

    //protected override void Start()
    //{
    //    base.Start();
    //    camera = Camera.main;
    //}

    private GameManager gameManager;
    private new Camera camera;

    public void Init(GameManager gameManager)
    {
        this.gameManager = gameManager;
        camera = Camera.main;
    }

    protected override void HandleAction()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        movementDirection = new Vector2(horizontal, vertical).normalized;

        Vector2 mousePosition = Input.mousePosition;
        Vector2 worldPos = camera.ScreenToWorldPoint(mousePosition);
        lookDirection = (worldPos - (Vector2)transform.position);

        if (lookDirection.magnitude < .9f)
        {
            lookDirection = Vector2.zero;
        }
        else
        {
            lookDirection = lookDirection.normalized;
        }

        isAttacking = Input.GetMouseButton(0);
    }

    public override void Death()
    {
        base.Death();
        gameManager.GameOver();
    }

    //void OnMove()
    //{
    //    float horizontal = Input.GetAxisRaw("Horizontal");
    //    float vertical = Input.GetAxisRaw("Vertical");
    //    movementDirection = new Vector2(horizontal, vertical).normalized;
    //}
    //void OnLook()
    //{
    //    Vector2 mousePosition = Input.mousePosition;
    //    Vector2 worldPos = camera.ScreenToWorldPoint(mousePosition);
    //    lookDirection = (worldPos - (Vector2)transform.position);

    //    if (lookDirection.magnitude < .9f)
    //    {
    //        lookDirection = Vector2.zero;
    //    }
    //    else
    //    {
    //        lookDirection = lookDirection.normalized;
    //    }
    //}
    //void OnFire()
    //{
    //    if (EventSystem.current.IsPointerOverGameObject())
    //        return;
    //    isAttacking = Input.GetMouseButton(0);
    //}
}

}

