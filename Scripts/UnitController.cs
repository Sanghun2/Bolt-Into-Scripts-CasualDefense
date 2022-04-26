using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//유닛의 행동을 컨트롤 하는 클래스. 매니저로 관리하지 않는 이유 => 움직이는 건 가능하지만 각각의 상황에 따라 애니메이션을 실행하기에는 개별적으로
//스크립트를 붙여주는 게 낫겠다고 판단함.
public class UnitController : MonoBehaviour
{
    Animator anim;
    UnitInfo info;

    Vector3 rightVec;

    void Awake()
    {
        rightVec = Vector3.right;
        anim = GetComponent<Animator>();
        info = GetComponent<UnitInfo>();
    }

    void OnEnable()
    {
        anim.SetTrigger("doMove");
    }

    void Update()
    {
        transform.position += rightVec * info.speed * Time.deltaTime;
    }
}
