using UnityEngine;

namespace Source.Character.Frog
{
    public class PlayerFrog : MonoBehaviour
    {
        public float runspeed = 2;
        public float jumpSpeed = 3;
        Rigidbody2D rb2d;

        private void Start()
        {
            rb2d = GetComponent<Rigidbody2D>();
        }


        private void FixedUpdate()
        {
            if (Input.GetKey(KeyCode.D) || Input.GetKey("right"))
            {
                rb2d.velocity = new Vector2(runspeed, rb2d.velocity.y);
            }
            else if (Input.GetKey(KeyCode.A) || Input.GetKey("left"))
            {
                rb2d.velocity = new Vector2(-runspeed, rb2d.velocity.y);
            }
            else
            {
                rb2d.velocity = new Vector2(0,rb2d.velocity.y);
            }

            if (Input.GetKey(KeyCode.Space) && CheckGround.isGround)
            {
                rb2d.velocity = new Vector2(rb2d.velocity.x, jumpSpeed);
            }






        }

    }
}
