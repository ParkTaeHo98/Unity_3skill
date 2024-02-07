using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyPlayerController : MonoBehaviour
{
    public event Action<Vector2> OnLookEvent;

    protected virtual void Awake()
    {
        
    }
    public void CallLookEvent(Vector2 value)
    {
        OnLookEvent?.Invoke(value);
    }
}
