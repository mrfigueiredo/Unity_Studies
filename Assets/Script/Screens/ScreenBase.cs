using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using NaughtyAttributes;

namespace Screens
{
    public enum ScreenType
    {
        MainMenu,
        About
    }

    public class ScreenBase : MonoBehaviour
    {
        public ScreenType screenType;

        public bool startHide = false;

        [SerializeField]
        private List<Transform> screenElements;
        public Image backgroundImage;

        [Header("Animation")]
        public float animationDuration = .3f;
        public float timeBetweenElementsAnimation = .5f;

        private void Start()
        {
            if(startHide)
            {
                HideObjects();
            }
        }


        [Button]
        public virtual void Show()
        {
            ShowObjects();
        }

        [Button]
        public virtual void Hide()
        {
            HideObjects();
        }

        private void HideObjects()
        {
            backgroundImage.enabled = false;
            screenElements.ForEach(e => e.gameObject.SetActive(false));
        }

        private void ForceShowObjects()
        {
            backgroundImage.enabled = true;
            screenElements.ForEach(e => e.gameObject.SetActive(true));
        }

        private void ShowObjects()
        {
            backgroundImage.enabled = true;
            for(int i =0; i < screenElements.Count; i++)
            {
                var element = screenElements[i];
                element.gameObject.SetActive(true);
                element.DOScale(0, animationDuration).From().SetDelay(timeBetweenElementsAnimation*i);
            }
        }

    }
}
