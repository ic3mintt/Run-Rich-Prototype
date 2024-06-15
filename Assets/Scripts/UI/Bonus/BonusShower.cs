using System.Collections;
using TMPro;
using UnityEngine;

namespace UI.Bonus
{
    public class BonusShower : MonoBehaviour
    {
        [SerializeField] private TMP_Text _tmp;
        [SerializeField] private Vector3 minScale = new Vector3(1f, 1f, 1f);
        [SerializeField] private Vector3 maxScale = new Vector3(1.3f, 1.3f, 1.3f);
        [SerializeField] private float scaleStep = 0.1f;
        [SerializeField] private float moveStep = 1f;

        private RectTransform _rectTransform;
        
        public void Show(float money)
        {
            if(money < 1)
                return;
            _rectTransform = GetComponent<RectTransform>();
            _tmp.text = $"+ {money.ToString()}";
            StartCoroutine(Show());
        }

        private IEnumerator Show()
        {
            float scale;
            while (transform.localScale.x < maxScale.x)
            {
                scale = Time.deltaTime * scaleStep;
                transform.localScale += new Vector3(scale, scale, scale);
                _rectTransform.position += new Vector3(0, moveStep * Time.deltaTime, 0);
                yield return new WaitForEndOfFrame();
            }

            gameObject.SetActive(false);
        }
    }
}