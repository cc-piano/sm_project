using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class StockTextView : MonoBehaviour
    {
        public float fromX;
        public float toX;
        public float duration;
        public float time = 0;
        public float timeWasted = 0;
        public RectTransform RectTransform;

        private void Update()
        {
            if (timeWasted >= duration)
            {
                time = 0;
                timeWasted = 0;
                RectTransform.anchoredPosition = new Vector3(fromX, RectTransform.anchoredPosition.y);
                return;
            }

            timeWasted += Time.deltaTime;
            RectTransform.anchoredPosition = new Vector3(Mathf.Lerp(fromX, toX, time), RectTransform.anchoredPosition.y);

            if (time < 1)
            {
                time += Time.deltaTime / duration;
            }
        }
    }
}