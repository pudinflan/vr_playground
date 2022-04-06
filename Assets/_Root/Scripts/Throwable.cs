using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class Throwable : OVRGrabbable
{
    [Header("Throw Values")]
    [SerializeField] float _throwSpeedMultiplier = 2f;

    public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
    {
        base.GrabEnd(linearVelocity, angularVelocity);
        
        Rigidbody rb = gameObject.GetComponent<Rigidbody>();
        rb.AddForce(linearVelocity * _throwSpeedMultiplier);
    }
}
