using UnityEngine;

namespace Mover
{
    public class Controller: IMovable
    {
        private readonly Model _model;
        private readonly Rigidbody _rigidbody;
        
        public Controller(Model model)
        {
            _model = model;
            _rigidbody = model.Rigidbody;
        }

        public void AllowMoveFromStart()
        {
            _model.IsAllowedToMove = true;
            _rigidbody.transform.position = _model.StartPosition;
        }

        public void Move(float deltaTime)
        {
            if(!_model.IsAllowedToMove)
                return;
            _rigidbody.position +=
                _rigidbody.transform.TransformDirection(new Vector3(0, 0, _model.ZSpeed * deltaTime));
        }

        public void Stop()
        {
            _model.IsAllowedToMove = false;
        }

        public void TurnTo(Quaternion target, float deltaTime)
        {
            if(!_model.IsAllowedToMove)
                return;
            _rigidbody.transform.rotation = Quaternion.RotateTowards(_rigidbody.transform.rotation, target, _model.RotationSpeed * deltaTime);
        }

        public void MoveHorizontal(float step, float deltaTime)
        {
            if(!_model.IsAllowedToMove)
                return;
            _rigidbody.position += 
                _rigidbody.transform.TransformDirection(new Vector3(step * deltaTime * _model.XSpeed, 0, 0));
        }
    }
}