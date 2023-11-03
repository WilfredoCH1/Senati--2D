using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Source
{

    public class ControlDeCamara : MonoBehaviour
    {
        public Transform personaje; // El transform del personaje 2D que seguir� la c�mara
        public float suavizado = 5f; // Controla la suavidad del seguimiento de la c�mara

        private Vector3 offset; // La distancia inicial entre la c�mara y el personaje

        void Start()
        {
            offset = transform.position - personaje.position;
        }

        void FixedUpdate()
        {
            Vector3 targetPosition = personaje.position + offset;
            transform.position = Vector3.Lerp(transform.position, targetPosition, suavizado * Time.deltaTime);
        }
    }

}
