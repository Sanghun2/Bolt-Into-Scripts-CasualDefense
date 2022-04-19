using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//카메라를 관리하는 클래스
public class CameraManager : MonoBehaviour
{
    [Header("카메라")]
    [SerializeField] Camera mainCamera;

    private bool isMovable = default;
    private float cameraSpeed = default;
    private readonly float SPEED_VALUE = 2;

    private Vector3 rightVec;

    void Awake()
    {
        rightVec = Vector3.right;
    }

    void Update()
    {
        if (IsMovable())
        {
            mainCamera.transform.position += rightVec * cameraSpeed * Time.deltaTime;
            BackgroundScroller.Instance.MoveBackground(cameraSpeed / SPEED_VALUE);
        }
    }

    //카메라 이동. by상훈
    public void MoveCamera(int dir)
    {
        if(dir == 1)
        {
            cameraSpeed += SPEED_VALUE;
        }
        else if (dir == -1)
        {
            cameraSpeed -= SPEED_VALUE;
        }
        else
        {
            Debug.LogWarning($"존재하지 않는 방향: {dir} in MoveCamera()");
        }
    }

    //카메라 정지. by상훈
    public void InitMove(int dir)
    {
        if (dir == 1)
        {
            cameraSpeed -= SPEED_VALUE;
        }
        else if (dir == -1)
        {
            cameraSpeed += SPEED_VALUE;
        }
        else
        {
            Debug.LogWarning($"존재하지 않는 방향: {dir} in MoveCamera()");
        }
    }

    //현재 이동가능한지 판별. by상훈
    bool IsMovable()
    {
        if ((mainCamera.transform.position.x <= SPEED_VALUE && cameraSpeed > 0) || (mainCamera.transform.position.x >= -SPEED_VALUE && cameraSpeed < 0))
        {
            isMovable = true;
        }
        else
        {
            isMovable = false;
        }

        return isMovable;
    }
}
