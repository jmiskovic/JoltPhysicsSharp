// Copyright � Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static JoltPhysicsSharp.JoltApi;

namespace JoltPhysicsSharp;

public sealed class PhysicsSystem : NativeObject
{
    public PhysicsSystem()
        : base(JPH_PhysicsSystem_Create())
    {
    }

    /// <summary>
    /// Finalizes an instance of the <see cref="PhysicsSystem" /> class.
    /// </summary>
    ~PhysicsSystem() => Dispose(isDisposing: false);

    protected override void Dispose(bool isDisposing)
    {
        if (isDisposing)
        {
            JPH_PhysicsSystem_Destroy(Handle);
        }
    }

    public void Init(uint maxBodies, uint numBodyMutexes, uint maxBodyPairs, uint maxContactConstraints, BroadPhaseLayer layer)
    {
        JPH_PhysicsSystem_Init(Handle, maxBodies, numBodyMutexes, maxBodyPairs, maxContactConstraints, layer.Handle);
    }

    public void OptimizeBroadPhase()
    {
        JPH_PhysicsSystem_OptimizeBroadPhase(Handle);
    }
}
