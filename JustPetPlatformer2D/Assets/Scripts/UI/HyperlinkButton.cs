using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace JustPet
{
    public class HyperlinkButton : CustomButton
    {
        [SerializeField] private string link;
        protected override void OnClickAction()
        {
            Application.OpenURL(link);
        }
    }
}