using UnityEngine;

namespace OWNproject.Camera
{
    public class CameraFollow : MonoBehaviour
    {
        [Header("Follow Settings")]
        public Transform target;
        public float smoothSpeed = 0.125f;
        public Vector3 offset = new Vector3(0, 1, -10);

        [Header("Boundaries")]
        public float minX, maxX;
        public float minY, maxY;

        private void LateUpdate() // Update가 아니라 LateUpdate를 쓰는 이유는, 플레이어 처리가 Update에서 진행될 것을 감안해서 이후에 작동하게 의도한 것.
        {
            if (target == null) return;
            Vector3 desiredPosition = target.position + offset;

            // 경계 제한
            desiredPosition.x = Mathf.Clamp(desiredPosition.x, minX, maxX); 
            desiredPosition.y = Mathf.Clamp(desiredPosition.y, minY, maxY);
            desiredPosition.z = -10; // Z축 고정

            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;

        }

    }

}
