using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//배경 스크롤에 대한 정보
public class ScrollInfo : MonoBehaviour
{
    [SerializeField] private float scrollSpeed;

    public float ScrollSpeed => scrollSpeed;
}
