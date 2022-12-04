using UnityEngine;

namespace Vfx
{
    [ExecuteInEditMode]
    public class CapsuleMovement : MonoBehaviour
    {
        [SerializeField] private float frequency = 1f;
        [SerializeField] private float amplitude = 2f;

        private void Update()
        {
            float x = Mathf.Cos(Time.time * frequency) * amplitude;
            float y = transform.position.y;
            float z = Mathf.Sin(Time.time * frequency) * amplitude;

            transform.position = new Vector3(x, y, z);
        }
    }
}
