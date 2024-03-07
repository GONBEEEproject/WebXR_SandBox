// Copyright (C) 2015-2021 ricimi - All rights reserved.
// This code can only be used under the standard Unity Asset Store End User License Agreement.
// A Copy of the Asset Store EULA is available at http://unity3d.com/company/legal/as_terms.

using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Ricimi
{
    /// <summary>
    /// Fundamental button class used throughout the demo.
    /// </summary>
    public class CleanButton2 : Button
    {
        private CleanButtonConfig config;
        private CanvasGroup canvasGroup;
        CleanButtonConfig2 buttonConfig2;

        Image thisImage;

        protected override void Awake()
        {
            image = GetComponent<Image>();
            buttonConfig2 = GetComponent<CleanButtonConfig2>();
        }

        public override void OnPointerEnter(PointerEventData eventData)
        {
            base.OnPointerEnter(eventData);

            image.sprite = buttonConfig2.hoverImage;

        }

        public override void OnPointerExit(PointerEventData eventData)
        {
            base.OnPointerExit(eventData);
            image.sprite = buttonConfig2.normalImage;

        }

        public override void OnPointerDown(PointerEventData eventData)
        {
            base.OnPointerDown(eventData);
            image.sprite = buttonConfig2.pressImgage;
        }

        public override void OnPointerUp(PointerEventData eventData)
        {
            base.OnPointerUp(eventData);
            image.sprite = buttonConfig2.hoverImage;
        }
    }
}