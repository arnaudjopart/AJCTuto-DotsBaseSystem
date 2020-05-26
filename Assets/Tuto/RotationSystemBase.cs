using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Transforms;
using UnityEngine;

public class RotationSystemBase : SystemBase
{
    protected override void OnUpdate()
    {
        var deltaTime = Time.DeltaTime;
        
        Entities.ForEach((ref RotateData _rotateData, ref Rotation _rotation) =>
        {
            _rotation.Value *= Quaternion.Euler(0, _rotateData.m_rotationSpeed * deltaTime, 0);
        }).ScheduleParallel();
    }
}
