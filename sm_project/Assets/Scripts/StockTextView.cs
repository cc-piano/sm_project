using System;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

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
        public Text Text;
        public float RandomMinValue;
        public float RandomMaxValue;
        public Color RandomMinColor;
        public Color RandomMaxColor;

        public void Init()
        {
            Text.text = $"{Random.Range(RandomMinValue, RandomMaxValue):0.00}";
            float randomColor = Random.Range(0f, 2f);    
            Text.color = Color.Lerp(RandomMinColor, RandomMaxColor, randomColor);
        }

        private void Update()
        {
            if (timeWasted >= duration)
            {
                time = 0;
                timeWasted = 0;
                RectTransform.anchoredPosition = new Vector3(fromX, RectTransform.anchoredPosition.y);
                Init();
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