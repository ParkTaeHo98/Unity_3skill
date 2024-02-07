using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LobbyLookController : MonoBehaviour
{
    [SerializeField] private GameObject headObject;
    [SerializeField] private GameObject CharacterObject;

    private LobbyPlayerController _controller;
    private void Awake()
    {
        _controller = GetComponent<LobbyPlayerController>();
    }
    void Start()
    {
        _controller.OnLookEvent += Look;
    }
    private void Look(Vector2 vector)
    {
        Looking(vector);
    }
    private void Looking(Vector2 vector)
    {
        float PosZ = Mathf.Atan2(vector.y, vector.x) * Mathf.Rad2Deg;
        if (Mathf.Abs(PosZ) > 90f)
        {
            headObject.transform.rotation = Quaternion.Euler(0, -180, (PosZ - 180)* -1);
            CharacterObject.transform.rotation = Quaternion.Euler(0f, -180, 0);
        } else {
            headObject.transform.rotation = Quaternion.Euler(0, 0, PosZ);
            CharacterObject.transform.rotation = Quaternion.Euler(0f, 0, 0);
        }
    }
}