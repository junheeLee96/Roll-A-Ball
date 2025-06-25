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
    }
}