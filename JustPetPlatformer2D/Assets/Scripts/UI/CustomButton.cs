using UnityEngine;
using UnityEngine.UI;

namespace JustPet
{
    [RequireComponent(typeof(Button))]
    public abstract class CustomButton : MonoBehaviour
    {
        protected void Awake()
        {
            Button button = GetComponent<Button>();
            if (button != null)
            {
                button.onClick.AddListener(OnClickAction);
            }
        }

        protected abstract void OnClickAction();
    }
}