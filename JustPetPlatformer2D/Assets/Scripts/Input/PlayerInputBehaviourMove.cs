using UnityEngine;
using UnityEngine.InputSystem;

namespace JustPet
{
    public class PlayerInputBehaviourMove : MonoBehaviour
    {
        [SerializeField] float speed = 5;

        public void OnInputMove(InputAction.CallbackContext context)
        {
            float direction = context.ReadValue<float>();
            Vector3 pos = this.transform.position;
            pos.x += direction * speed;
            this.transform.position = pos;
        }

    }
}