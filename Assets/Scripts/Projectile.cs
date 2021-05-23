using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Projectile : MonoBehaviour
{
    [HideInInspector] public new Rigidbody rigidbody;

    // Reset is called when you add the component to the game object.
    // Reset is also called when you reset the game object in the editor
    public void Reset()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
}
