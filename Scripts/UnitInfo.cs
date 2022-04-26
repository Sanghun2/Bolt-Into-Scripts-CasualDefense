using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator), typeof(BoxCollider2D), typeof(UnitController))]
public class UnitInfo : MonoBehaviour
{
    public UnitManager.Type type;
    public float speed;
}
