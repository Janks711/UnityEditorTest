using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplineComponent : MonoBehaviour, ISpline
{
    public Vector3 GetNonUniformPoint(float t)
    {
        throw new System.NotImplementedException();
    }

    public Vector3 GetPoint(float t)
    {
        throw new System.NotImplementedException();
    }

    public Vector3 GetLeft(float t)
    {
        throw new System.NotImplementedException();
    }

    public Vector3 GetRight(float t)
    {
        throw new System.NotImplementedException();
    }

    public Vector3 GetUp(float t)
    {
        throw new System.NotImplementedException();
    }

    public Vector3 GetDown(float t)
    {
        throw new System.NotImplementedException();
    }

    public Vector3 GetForward(float t)
    {
        throw new System.NotImplementedException();
    }

    public Vector3 GetBackward(float t)
    {
        throw new System.NotImplementedException();
    }

    public float GetLenght(float stepSize)
    {
        throw new System.NotImplementedException();
    }

    public Vector3 GetControlPoint(int index)
    {
        throw new System.NotImplementedException();
    }

    public void SetControlPoint(int index, Vector3 position)
    {
        throw new System.NotImplementedException();
    }

    public void InsertControlPoint(int index, Vector3 position)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveControlPointI(int index)
    {
        throw new System.NotImplementedException();
    }

    public Vector3 GetDistance(float distance)
    {
        throw new System.NotImplementedException();
    }

    public Vector3 FindClosest(Vector3 worldPoint)
    {
        throw new System.NotImplementedException();
    }

    public int ControlPoint { get; }
}
