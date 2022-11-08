using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using DG.Tweening;

namespace Screens
{
    public class ButtonScaler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        public float scaleMultiplier = .2f;
        public float animationDuration = .1f;

        private Vector3 _initialScale;
        private Tween _currentTween;

        private void Awake()
        {
            _initialScale = transform.localScale;
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            _currentTween = transform.DOScale(.2f, animationDuration).SetRelative();
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            _currentTween.Kill();
            transform.localScale = _initialScale;
        }
    }
}