using System;
using System.Linq;
using UnityEngine;

namespace Input
{
    public class InputHandler : MonoBehaviour
    {
        private float lastTouchXPoint;
        private float currentTouchXPoint;
        private float screenWidth;
        private float normalizedStep;

        public event Action<float, float> OnStepChange;
        
        private void Awake()
        {
            screenWidth = Camera.main.pixelWidth;
        }

        private void Update()
        {
            var beganTouch = UnityEngine.Input.touches.Where(touch => touch.phase == TouchPhase.Began);
            var movedTouches = UnityEngine.Input.touches.Where(touch => touch.phase == TouchPhase.Moved);
            
            if (beganTouch.Any())
            {
                lastTouchXPoint = currentTouchXPoint = beganTouch.First().position.x;
            }
            else if (movedTouches.Any())
            {
                currentTouchXPoint = movedTouches.First().position.x;
            }

            normalizedStep = (currentTouchXPoint - lastTouchXPoint)/screenWidth;
            lastTouchXPoint = currentTouchXPoint;
            OnStepChange?.Invoke(normalizedStep, Time.deltaTime);
        }
    }
}