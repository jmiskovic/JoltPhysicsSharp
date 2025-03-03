// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using System.Numerics;
using static JoltPhysicsSharp.JoltApi;

namespace JoltPhysicsSharp;

public sealed class PointConstraintSettings : TwoBodyConstraintSettings
{
    public PointConstraintSettings()
        : base(JPH_PointConstraintSettings_Create())
    {
    }

    /// <summary>
    /// Finalizes an instance of the <see cref="PointConstraintSettings" /> class.
    /// </summary>
    ~PointConstraintSettings() => Dispose(isDisposing: false);

    public override TwoBodyConstraint CreateConstraint(in Body body1, in Body body2)
    {
        return new PointConstraint(JPH_PointConstraintSettings_CreateConstraint(Handle, body1.Handle, body2.Handle));
    }

    public ConstraintSpace Space
    {
        get => JPH_PointConstraintSettings_GetSpace(Handle);
        set => JPH_PointConstraintSettings_SetSpace(Handle, value);
    }

    public Double3 Point1
    {
        get
        {
            JPH_PointConstraintSettings_GetPoint1(Handle, out Double3 value);
            return value;
        }
        set
        {
            JPH_PointConstraintSettings_SetPoint1(Handle, value);
        }
    }

    public Double3 Point2
    {
        get
        {
            JPH_PointConstraintSettings_GetPoint2(Handle, out Double3 value);
            return value;
        }
        set
        {
            JPH_PointConstraintSettings_SetPoint2(Handle, value);
        }
    }

    public void GetPoint1(out Double3 value)
    {
        JPH_PointConstraintSettings_GetPoint1(Handle, out value);
    }

    public void GetPoint2(out Double3 value)
    {
        JPH_PointConstraintSettings_GetPoint2(Handle, out value);
    }
}

public sealed class PointConstraint : TwoBodyConstraint
{
    internal PointConstraint(IntPtr handle)
        : base(handle)
    {
    }

    /// <summary>
    /// Finalizes an instance of the <see cref="PointConstraint" /> class.
    /// </summary>
    ~PointConstraint() => Dispose(isDisposing: false);
}
