using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float zoomSpeed;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float padding;

    Vector3 moveDir;
    private float zoomScroll;

    private void OnEnable()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }

    private void OnDisable()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    private void LateUpdate()
    {
        Move();
        Zoom();
    }

    private void Move()
    {
        transform.Translate(Vector3.forward* moveDir.y * moveSpeed * Time.deltaTime, Space.World);
        transform.Translate(Vector3.right * moveDir.x * moveSpeed * Time.deltaTime, Space.World);
    }

    private void OnPointer(InputValue value) 
    {
        Vector3 mousPos = value.Get<Vector2>();
        if (mousPos.x <= 0+padding) // 왼쪽
            moveDir.x = -1;
        else if (mousPos.x >= Screen.width - padding)   // 오른쪽
            moveDir.x = 1;
        else
            moveDir.x = 0;

        if (mousPos.y <= 0+padding) //위
            moveDir.y = -1;
        else if (mousPos.y >= Screen.height - padding)  // 아래
            moveDir.y = 1;
        else
            moveDir.y = 0;

    }

    private void Zoom()
    {
        transform.Translate(Vector3.forward * zoomSpeed * zoomScroll * Time.deltaTime, Space.Self);
    }

    private void OnZoom(InputValue value)
    {
        zoomScroll = value.Get<Vector2>().y;
    }

   
}
