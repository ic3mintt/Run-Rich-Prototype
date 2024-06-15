using UnityEngine;

namespace UI
{
    public class Wheel : MonoBehaviour
    {
        [SerializeField] private RectTransform _rectTransform;
        [SerializeField] private float _minZAngle = 60f;
        [SerializeField] private float _maxZAngle = -75f;
        [SerializeField] private float _speed = 0.5f;

        
        private void OnEnable()
        {
            // _rectTransform.rotation = Quaternion.Euler(0, 0, _minZAngle);;
        }
        //
        // private IEnumerator RotateRight()
        // {
        //     while ()
        //     {
        //         _rectTransform.Rotate();
        //     }
        // }
    }
}