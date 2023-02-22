using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    private Camera _mainCamera;
    
    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _mainCamera = Camera.main;
    }
    private void Update() => MovePlayerWithMouse(GetMouseWorldPos());

    private void MovePlayerWithMouse(Vector2 worldMousePos)
    {
        if (!(worldMousePos.x <= 2.3f) ||
            !(worldMousePos.x >= -2.3f) ||
            !(worldMousePos.y >= -4.5f) ||
            !(worldMousePos.y <= 4.5f)) return;
        
        _rigidbody2D.MovePosition(worldMousePos);
    }
    
    private Vector2 GetMouseWorldPos()
    {
        Vector2 mousePos = Input.mousePosition;
        return _mainCamera.ScreenToWorldPoint(mousePos); 
    }
}
