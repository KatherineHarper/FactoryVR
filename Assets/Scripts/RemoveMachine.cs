using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace VRFP
{
    public class RemoveMachine : MonoBehaviour
    {
        Collider coll;
        public Button button1;
        public AudioSource RemoveAudio;
        public GameObject MMenu;
        void Start()
        {
            coll = GetComponent<Collider>();

        }
        //hover
        //options pannel follows person
        //option 1 remove
        //option 2 rotate
        public void RemoveButton()
        {
            RemoveAudio.Play();
            gameObject.SetActive(false);
            MMenu.SetActive(false);

        }
        public void RotateButton() {
        //rotate 90
        //rotate 45
        
        }
        public void Update()
        {

            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (coll.Raycast(ray, out hit, 100.0f))
                {

                     MMenu.SetActive(true);
                    RemoveAudio.Play();
                   

                    button1.GetComponent<Button>().interactable = true;
                }

            }

        }
    }
}