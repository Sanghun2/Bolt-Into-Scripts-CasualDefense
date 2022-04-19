using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ī�޶� �����ϴ� Ŭ����
public class CameraManager : MonoBehaviour
{
    [Header("ī�޶�")]
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

    //ī�޶� �̵�. by����
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
            Debug.LogWarning($"�������� �ʴ� ����: {dir} in MoveCamera()");
        }
    }

    //ī�޶� ����. by����
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
            Debug.LogWarning($"�������� �ʴ� ����: {dir} in MoveCamera()");
        }
    }

    //���� �̵��������� �Ǻ�. by����
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
