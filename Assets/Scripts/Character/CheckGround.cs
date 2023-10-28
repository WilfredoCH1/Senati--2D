using UnityEngine;

namespace Source.Character.Frog
{
    public class CheckGround : MonoBehaviour
    {
        public static bool isGround;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            isGround = true;
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            isGround = false;
        }

    }
}
