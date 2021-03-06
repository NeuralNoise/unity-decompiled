﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.JointSuspension2D
// Assembly: UnityEngine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A8FF7A2C-E4EE-4232-AB17-3FCABEC16496
// Assembly location: C:\Users\Blake\sandbox\unity\test-project\Library\UnityAssemblies\UnityEngine.dll

namespace UnityEngine
{
  /// <summary>
  ///   <para>Joint suspension is used to define how suspension works on a WheelJoint2D.</para>
  /// </summary>
  public struct JointSuspension2D
  {
    private float m_DampingRatio;
    private float m_Frequency;
    private float m_Angle;

    /// <summary>
    ///   <para>The amount by which the suspension spring force is reduced in proportion to the movement speed.</para>
    /// </summary>
    public float dampingRatio
    {
      get
      {
        return this.m_DampingRatio;
      }
      set
      {
        this.m_DampingRatio = value;
      }
    }

    /// <summary>
    ///   <para>The frequency at which the suspension spring oscillates.</para>
    /// </summary>
    public float frequency
    {
      get
      {
        return this.m_Frequency;
      }
      set
      {
        this.m_Frequency = value;
      }
    }

    /// <summary>
    ///   <para>The world angle (in degrees) along which the suspension will move.</para>
    /// </summary>
    public float angle
    {
      get
      {
        return this.m_Angle;
      }
      set
      {
        this.m_Angle = value;
      }
    }
  }
}
