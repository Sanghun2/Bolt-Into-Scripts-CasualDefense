using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator), typeof(BoxCollider2D))]
public class UnitInfo : MonoBehaviour
{
    [SerializeField] private UnitManager.Type type;
    [SerializeField] private float speed;
}
