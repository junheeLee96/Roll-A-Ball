using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class ItemCan : MonoBehaviour
    {
        public float rotateSpeed ;

        void Update()
        {
            // transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
            transform.parent.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
        }

        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("Parent: " + transform.parent.name);
            if (other.name == "Player")
            {
                
                PlayerBall player = other.GetComponent<PlayerBall>();
                player.itemCount ++;
                // 오브젝트 활성화 함수
                // gameObject.SetActive(false);
                Debug.Log("Parent: " + transform.parent.name);
                transform.parent.gameObject.SetActive(false);
                

            }
        }
    }
}