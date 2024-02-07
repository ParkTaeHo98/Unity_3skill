using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputPlayerController : LobbyPlayerController
{
    private Camera _camera;

    protected override void Awake()
    {
        base.Awake();
        _camera = Camera.main;
    }
   public void OnLook(InputValue value)
    {
        Vector2 mousePos = value.Get<Vector2>();
        Vector2 worldPos = _camera.ScreenToWorldPoint(mousePos);
        mousePos = (worldPos-(Vector2)transform.position).normalized;

        if (mousePos.magnitude >= 0.9f)
        {
            CallLookEvent(mousePos);
        }
    }
}