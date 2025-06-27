using UnityEngine;
using UnityEngine.SceneManagement;

namespace DefaultNamespace
{
    public class PlayerBall : MonoBehaviour
    {
        private Rigidbody rigid;
        bool isJumping = false;
        public float junpPower = 10f;
        public int itemCount;
        private AudioSource audio;

        public GameManager manager;

       
        void Awake()
        {
            rigid = GetComponent<Rigidbody>();
            audio = GetComponent<AudioSource>();
            
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
        
        private void OnTriggerEnter(Collider other) 
        {
            if (other.CompareTag("Item"))
            {
                itemCount ++;
                audio.Play();
                other.transform.parent.gameObject.SetActive(false);
            }else if (other.CompareTag("Finish"))
            {

                if (manager.totalItemCount == itemCount)
                {
                    // game over
                    
                }
                else
                {
                    // rest
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                }
            }
        }
    }
}