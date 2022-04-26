using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//������ �ൿ�� ��Ʈ�� �ϴ� Ŭ����. �Ŵ����� �������� �ʴ� ���� => �����̴� �� ���������� ������ ��Ȳ�� ���� �ִϸ��̼��� �����ϱ⿡�� ����������
//��ũ��Ʈ�� �ٿ��ִ� �� ���ڴٰ� �Ǵ���.
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
