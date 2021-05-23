using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplineComponent : MonoBehaviour, ISpline
{
    public bool closed = false;
    public List<Vector3> points = new List<Vector3>();
    public float? length;
    
    
    public Vector3 GetNonUniformPoint(float t)
    {
        switch (points.Count)
        {
            case 0:
                return Vector3.zero;
            case 1:
                return transform.TransformPoint(points[0]);
            case 2:
                return transform.TransformPoint(Vector3.Lerp(points[0], points[1], t));
            case 3:
                return transform.TransformPoint(points[1]);
            default:
                return Hermite(t);
            
        }
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
        return points[index];
    }

    public void SetControlPoint(int index, Vector3 position)
    {
        ResetIndex();
        points[index] = position;
    }



    public void InsertControlPoint(int index, Vector3 position)
    {
        ResetIndex();
        if (index >= points.Count)
        {
            points.Add(position);
        }
        else
        {
            points.Insert(index, position);
        }
    }

    public void RemoveControlPointI(int index)
    {
        ResetIndex();
        points.RemoveAt(index);
    }

    public Vector3 GetDistance(float distance)
    {
        throw new System.NotImplementedException();
    }

    public Vector3 FindClosest(Vector3 worldPoint)
    {
        throw new System.NotImplementedException();
    }

    public int ControlPointCount => points.Count;
    
    private void ResetIndex()
    {
        throw new NotImplementedException();
    }

    private Vector3 Hermite(float t)
    {
        var count = points.Count - (closed ? 0 : 3);
        var i = Mathf.Min(Mathf.FloorToInt(t * (float) count), count - 1);
        var u = t * (float) count - (float) i;
        var a = GetPointByIndex(i);
        var b = GetPointByIndex(i + 1);
        var c = GetPointByIndex(i + 2);
        var d = GetPointByIndex(i + 3);
        return transform.TransformPoint(Interpolate(a, b, c, d, u));
    }

    private Vector3 GetPointByIndex(int index)
    {
        if (index < 0) index += points.Count;
        return points[index % points.Count];
    }

    // This is a hermite spline interpolation function
    internal static Vector3 Interpolate(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float u)
    {
        return (0.5f *
                (
                    (-a + 3f * b - 3f * c + d) *
                    (u * u * u) +
                    (2f * a - 5f * b + 4f * c - d) *
                    (u * u) +
                    (-a + c) *
                    u + 2f * b
                )
            );
    }
}
