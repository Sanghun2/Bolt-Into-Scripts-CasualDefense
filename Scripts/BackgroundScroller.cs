using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//��潺ũ�Ѹ��� �����ϴ� Ŭ����
public class BackgroundScroller : MonoBehaviour
{
    [Header("������ ���")]
    [SerializeField] private ScrollInfo[] scrollInfo;

    Vector3 rightVec;

    private static BackgroundScroller instance;
    public static BackgroundScroller Instance => instance;

    void Awake()
    {
        instance = this;

        rightVec = Vector3.right;
    }

    public void MoveBackground(float speedValue)
    {
        foreach (var s in scrollInfo)
        {
            s.gameObject.transform.position += rightVec * s.ScrollSpeed * speedValue * Time.deltaTime;
        }

        print("�̵���");
    }
}
