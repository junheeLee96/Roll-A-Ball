using UnityEngine;
// using UnityEngine.SceneManagement;
namespace DefaultNamespace
{
    public class CameraMove : MonoBehaviour
    {
        private Transform playerTransform;
        private Vector3 Offset;
        // public GameManager manager;
        void Awake()
        {
            playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
            Debug.Log(playerTransform);
            
            Offset = playerTransform.position - transform.position;
        }

        void LateUpdate()
        {
            transform.position = playerTransform.position - Offset;
            
        }
    }
}