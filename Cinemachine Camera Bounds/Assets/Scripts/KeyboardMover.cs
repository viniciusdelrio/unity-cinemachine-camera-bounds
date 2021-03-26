using UnityEngine;

namespace CameraBounds
{
    public class KeyboardMover : MonoBehaviour
    {
        [SerializeField] private float moveSpeed = 10.0f;

        private void Update()
        {
            var direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            transform.Translate(direction * moveSpeed * Time.deltaTime);
        }
    }
}