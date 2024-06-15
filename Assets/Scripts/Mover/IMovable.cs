using UnityEngine;

namespace Mover
{
    public interface IMovable
    {
        public void AllowMoveFromStart();
        public void Move(float deltaTime);

        public void Stop();

        public void TurnTo(Quaternion target, float deltaTime);

        public void MoveHorizontal(float step, float deltaTime);
    }
}