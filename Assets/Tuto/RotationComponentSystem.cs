﻿using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

public class RotationComponentSystem : ComponentSystem
{
    protected override void OnUpdate()
    {
        Entities.ForEach((ref RotateData _rotateData, ref Rotation _rotation) =>
            {
                //_rotation.Value *= Quaternion.Euler(0, _rotateData.m_rotationSpeed * Time.DeltaTime, 0);
            });
    }
}
