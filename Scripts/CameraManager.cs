using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//카메라를 관리하는 클래스
public class CameraManager : MonoBehaviour
{
    bool isMovable;
    float cameraSpeed;

    //카메라 이동. by상훈
    public void MoveCamera(int dir)
    {
        if(dir == 1)
        {
            print("1");
        }
        else if (dir == -1)
        {

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
            print("0");
        }
        else if (dir == -1)
        {

        }
        else
        {
            Debug.LogWarning($"존재하지 않는 방향: {dir} in MoveCamera()");
        }
    }
}
