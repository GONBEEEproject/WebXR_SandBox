// Copyright (C) 2015-2021 ricimi - All rights reserved.
// This code can only be used under the standard Unity Asset Store End User License Agreement.
// A Copy of the Asset Store EULA is available at http://unity3d.com/company/legal/as_terms.

using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using DG.Tweening;

namespace Ricimi
{
    /// <summary>
    /// Fundamental button class used throughout the demo.
    /// </summary>
    public class CleanButton : Button
    {
        private CleanButtonConfig config;
        private CanvasGroup canvasGroup;
        Image image;
        Color baseColor;

        protected override void Awake()
        {
            config = GetComponent<CleanButtonConfig>();
            canvasGroup = GetComponent<CanvasGroup>();
            image = GetComponent<Image>();
            baseColor = image.color;

            if (canvasGroup == null)
            {
                canvasGroup = gameObject.AddComponent<CanvasGroup>();
            }
        }

        public override void OnPointerEnter(PointerEventData eventData)
        {
            base.OnPointerEnter(eventData);
            //StopAllCoroutines();
            //StartCoroutine(Utils.FadeOut(canvasGroup, config.onHoverAlpha, config.fadeTime));

            image.DOColor(Color.white, config.fadeTime);


        }

        public override void OnPointerExit(PointerEventData eventData)
        {
            base.OnPointerExit(eventData);
            //StopAllCoroutines();
            //StartCoroutine(Utils.FadeIn(canvasGroup, 1.0f, config.fadeTime));
            image.DOColor(baseColor, config.fadeTime);
        }

        public override void OnPointerDown(PointerEventData eventData)
        {
            base.OnPointerDown(eventData);
            //canvasGroup.alpha = config.onClickAlpha;
            image.DOColor(new Color((baseColor.r + 1)/2 , (baseColor.g + 1) / 2, (baseColor.b + 1) / 2) , config.fadeTime);
        }

        public override void OnPointerUp(PointerEventData eventData)
        {
            base.OnPointerUp(eventData);
            //canvasGroup.alpha = 1.0f;
            image.DOColor(baseColor, config.fadeTime);

        }
    }
}