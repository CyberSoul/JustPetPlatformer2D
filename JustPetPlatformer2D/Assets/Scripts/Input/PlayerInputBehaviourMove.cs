using UnityEngine;
using UnityEngine.InputSystem;

namespace JustPet
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerInputBehaviourMove : MonoBehaviour
    {
        [SerializeField] float speed = 5;
        [SerializeField] float jumpPower = 5;

        [SerializeField] LayerMask jumpLayers;

        Rigidbody2D rigidBody;
        BoxCollider2D collider;
        float directionMove = 0;

        private void Awake()
        {
            rigidBody = GetComponent<Rigidbody2D>();
            if (rigidBody == null)
            {
                Debug.LogError("Have not rigid body 2D for Player");
                Destroy(this.gameObject);
            }
            collider = GetComponent<BoxCollider2D>();
            if (collider == null)
            {
                Debug.LogError("Have not BoxCollider2D for Player");
                Destroy(this.gameObject);
            }
        }

        private void Update()
        {
            //if (IsOnCollider())
            {
                Vector3 rbVelocity = rigidBody.velocity;
                rbVelocity.x = directionMove;
                rigidBody.velocity = rbVelocity;
            }
        }

        public void OnInputMove(InputAction.CallbackContext context)
        {
            directionMove = context.ReadValue<float>() * speed;
        }

        public void OnInputJump(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                //TO_DO: add check is on ground or maybe another flow-check
                if (IsOnCollider())
                {
                    rigidBody.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
                }
            }
        }

        private bool IsOnCollider()
        {
            /*Vector2 feetPosition = new Vector2(transform.position.x, transform.position.y - GetComponent<SpriteRenderer>().bounds.extents.y);
            RaycastHit2D hit = Physics2D.Raycast(feetPosition, Vector2.down, 0.1f, jumpLayers);
            return hit.collider != null;*/


            Vector2 position = transform.position;
            position += collider.offset;
            Vector2 size = collider.size;
            float halfHeight = size.y / 2f;
            float halfWidth = size.x / 2f - 0.01f; //Not calculated when on limit
            Vector2 startPoint = new Vector2(position.x - halfWidth, position.y - halfHeight - 0.01f);
            Vector2 endPoint = new Vector2(position.x + halfWidth, position.y - halfHeight - 0.1f);

            Collider2D[] colliders = Physics2D.OverlapAreaAll(startPoint, endPoint, jumpLayers);
            for (int i = 0; i < colliders.Length; ++i)
            {
                if (colliders[i].gameObject != this.gameObject)
                {
                    return true;
                }
            }

            return false;
        }

    }
}