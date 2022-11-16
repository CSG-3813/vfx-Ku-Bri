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


    private bool TargetInFOV(Transform target)
    {
        Vector3 DirToTarget = target.position - EyePoint.position;
        float angle = Vector3.Angle(EyePoint.forward, DirToTarget);

        if(angle <= FieldofView)
        {
            return true;
        }

        return false;
    }


    private bool HasClearLineOfSIghtToTarget(Transform target)
    {
        RaycastHit info;

        Vector3 DirToTarget = (target.position - EyePoint.position).normalized;

        if(Physics.Raycast(EyePoint.position, DirToTarget, out info, ThisCollider.radius)
        {
            if (info.transform.CompareTag(TargetTag))
            {
                return true;
            }
        }
        return false;
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
