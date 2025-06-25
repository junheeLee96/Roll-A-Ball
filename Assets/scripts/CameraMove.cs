using UnityEngine;

namespace DefaultNamespace
{
    public class CameraMove : MonoBehaviour
    {
        private Transform playerTransform;
        private Vector3 Offset;
        void Awake()
        {
            playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
            Offset = playerTransform.position - transform.position;
        }

        void LateUpdate()
        {
            transform.position = playerTransform.position - Offset;
            
        }
    }
}