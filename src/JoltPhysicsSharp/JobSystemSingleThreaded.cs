// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static JoltPhysicsSharp.JoltApi;

namespace JoltPhysicsSharp;

public sealed class JobSystemSingleThreaded : JobSystem
{
    public JobSystemSingleThreaded(int maxJobs)
        : base(JPH_JobSystemSingleThreaded_Create((uint)maxJobs))
    {
    }
}
