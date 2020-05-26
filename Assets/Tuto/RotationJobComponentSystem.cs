using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Jobs;
using Unity.Transforms;
using UnityEngine;

public class RotationJobComponentSystem : JobComponentSystem
{
    
    protected override JobHandle OnUpdate(JobHandle inputDeps)
    {
        var deltaTime = Time.DeltaTime;
        JobHandle handle = Entities.ForEach((ref RotateData _rotateData, ref Rotation _rotation) =>
            {
                //_rotation.Value *= Quaternion.Euler(0, _rotateData.m_rotationSpeed * deltaTime, 0);
            })
            .Schedule(inputDeps);

        return handle;
    }
}
