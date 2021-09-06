using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// in report.....////.....
namespace VRFP
{
    public class MachineOptions : MonoBehaviour
    {
        Collider coll;
        public Button button;
        public AudioSource RemoveAudio;
        public GameObject MMenu;
        public Text MachineInfo;
        
        public 
        float AddDeg;
        
        void Start()
        {
            coll = GetComponent<Collider>();
           
        }
        
        public void RemoveButton()
        {
            RemoveAudio.Play();
            gameObject.SetActive(false);
            MMenu.SetActive(false);

        }

        string ShowMachineInfo()
        {
            string Info = "";
           
            Info += "Machine Name " + gameObject.name + "“\r\n”";
         
            return Info;
        }

      
     
        public void Rotate() {

            AddDeg =+ 90.0f;
            gameObject.transform.Rotate(0.0f, AddDeg, 0.0f, Space.Self);
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
                    MachineInfo.text = ShowMachineInfo();
                    RemoveAudio.Play();
                   

                    button.GetComponent<Button>().interactable = true;
                }

            }

        }
    }
}