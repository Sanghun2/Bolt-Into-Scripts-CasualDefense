using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ī�޶� �����ϴ� Ŭ����
public class CameraManager : MonoBehaviour
{
    bool isMovable;
    float cameraSpeed;

    //ī�޶� �̵�. by����
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
            Debug.LogWarning($"�������� �ʴ� ����: {dir} in MoveCamera()");
        }
    }

    //ī�޶� ����. by����
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
            Debug.LogWarning($"�������� �ʴ� ����: {dir} in MoveCamera()");
        }
    }
}
