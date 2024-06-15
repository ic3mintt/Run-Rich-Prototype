using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class Swipper : MonoBehaviour
    {
        [SerializeField] private Slider _slider;
        [SerializeField] private float minValue = 0.1f;
        [SerializeField] private float maxValue = 0.9f;
        [SerializeField] private float speed = 0.01f;

        private float coeff;
        private Coroutine moveCoroutine;
        
        private void OnEnable()
        {
            _slider.value = minValue;
            coeff = minValue + speed;
            moveCoroutine = StartCoroutine(MoveRight());
        }

        private void OnDisable()
        {
            Stop();
        }

        private IEnumerator MoveRight()
        {
            while (_slider.value < maxValue)
            {
                _slider.value += coeff * Time.deltaTime;
                yield return new WaitForEndOfFrame();
            }

            moveCoroutine = StartCoroutine(MoveLeft());
        }

        private IEnumerator MoveLeft()
        {
            while (_slider.value > minValue)
            {
                _slider.value -= coeff * Time.deltaTime;
                yield return new WaitForEndOfFrame();
            }
            
            moveCoroutine = StartCoroutine(MoveRight());
        }
        
        private void Stop()
        {
            if (moveCoroutine != null)
            {
                StopCoroutine(moveCoroutine);
                moveCoroutine = null;
            }
        }
    }
}