using System;
using UnityEngine;

namespace Mover
{
    [Serializable]
    public class Model
    {
        public Rigidbody Rigidbody;
        public float XSpeed = 600f;
        public float ZSpeed = 1f;
        public float RotationSpeed = 1f;
        public bool IsAllowedToMove = false;
        public Vector3 StartPosition = new (0, 0, -8.68f);
    }
}