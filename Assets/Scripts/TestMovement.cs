using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VRFP
{
    public class TestMovement : MonoBehaviour
    {

        Renderer m_Renderer;


        void Start()
        {
            MainManager.Instance.isTouching = false;
            m_Renderer = gameObject.GetComponent<Renderer>();
            m_Renderer.material.color = Color.green;
        }
        void Update()
        {

            MovePosition();

        }
        void OnTriggerEnter(Collider other)
        {

            MainManager.Instance.isTouching = true;
            m_Renderer.material.color = Color.red;
        }
        void OnTriggerExit(Collider other)
        {
            MainManager.Instance.isTouching = false;
            m_Renderer.material.color = Color.green;
        }

        void MovePosition()
        {

            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.position += Vector3.forward * Time.deltaTime * 5;
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.position += Vector3.back * Time.deltaTime * 5;
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.position += Vector3.right * Time.deltaTime * 5;
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position += Vector3.left * Time.deltaTime * 5;
            }
        }

    }
}


