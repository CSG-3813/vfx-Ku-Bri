using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class SightLine : MonoBehaviour
{

    public Transform EyePoint;
    public string TargetTag = "Player";
    public float FieldofView = 45f;
    

    private bool IsTargetInSightLine { get; set; } = false;

    public Vector3 LastKnownSighting { get; set; } = Vector3.zero;

    private SphereCollider ThisCollider;

    private void Awake()
    {
        ThisCollider = GetComponent<SphereCollider>();
        LastKnownSighting = transform.position;

    }

   /*** 
    private void UpdateSight(Transform target)
    {
        IsTargetInSight = 
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            UpdateSight(other.transform);
        }
    }
   ***/


}
