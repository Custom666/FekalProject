using UnityEngine;

namespace Assets.Scripts
{
    public class PlayerController : MonoBehaviour
    {
        public float Speed = 10f;

        private Rigidbody _rigidbody;

        private Vector3 _move;

        // Use this for initialization
        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            _move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * Time.deltaTime * Speed;
        }

        // Update is called once per frame
        private void FixedUpdate()
        {
            _rigidbody.MovePosition(transform.position + _move);
            _rigidbody.AddTorque(_move);
        }
    }
}
