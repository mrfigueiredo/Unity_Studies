using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollower : MonoBehaviour
{
    public float maxMoveSpeed = 10;
    public float smoothTime = .3f;
    public float minDistance = 2;

    private Vector2 _currentVelocity;
    void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition += ((Vector2)transform.position - mousePosition).normalized * minDistance;
        transform.position = Vector2.SmoothDamp(transform.position, mousePosition, ref _currentVelocity, smoothTime, maxMoveSpeed);
    }
}
