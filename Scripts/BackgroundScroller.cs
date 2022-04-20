using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//배경스크롤링을 관리하는 클래스
public class BackgroundScroller : MonoBehaviour
{
    [Header("움직일 배경")]
    [SerializeField] private ScrollInfo[] scrollInfo;

    Vector3 rightVec;

    private static BackgroundScroller instance;
    public static BackgroundScroller Instance => instance;

    void Awake()
    {
        instance = this;

        rightVec = Vector3.right;
    }

    public void MoveBackground(float unitValue)
    {
        foreach (var s in scrollInfo)
        {
            s.gameObject.transform.position += unitValue * rightVec * s.ScrollSpeed * Time.deltaTime;
        }
    }
}
