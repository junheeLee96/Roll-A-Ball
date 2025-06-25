using UnityEngine;

namespace DefaultNamespace
{
    public class PlayerBall : MonoBehaviour
    {
        private Rigidbody rigid;
        bool isJumping = false;
        public float junpPower = 10f;
        public int itemCount;
        void Awake()
        {
            rigid = GetComponent<Rigidbody>();
            
        }

        void Update()
        {
            if (Input.GetButtonDown("Jump") && !isJumping)
            {
                isJumping=true;
                rigid.AddForce(new Vector3(0,junpPower,0),ForceMode.Impulse);
                
            }
        }
        void FixedUpdate() 
        {
            float h = Input.GetAxisRaw("Horizontal");
            float v = Input.GetAxisRaw("Vertical");
            rigid.AddForce(new Vector3(h,0,v),ForceMode.Impulse);
        }
        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.name == "Floor")
            {
                isJumping = false;
            }
        }
    }
}