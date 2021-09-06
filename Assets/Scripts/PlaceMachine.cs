using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// in report.....////.....
namespace VRFP
{
    public class PlaceMachine : MonoBehaviour
    {
        public Button[] ButtonMachines;
        public GameObject[] Machines;
        public AudioSource PlaceSound;
        public AudioSource NoPlaceSound;
        public GameObject placetospawn;
        public MainManager manager;
        public Transform ptstrans;

        List<Button> Buttons = new List<Button>();





        public void Start()
        {
            Buttons.AddRange(ButtonMachines);


        }
        public void Update()
        {


            ptstrans = placetospawn.GetComponent<Transform>();
           

        }

        public void ButtonMachine1()
        {

            SearchMachines("M1-Inq-Bit 280000");
        }
        public void ButtonMachine2()
        {
            SearchMachines("M2-Setter-0098-TY700");

        }
        public void ButtonMachine3()
        {
            SearchMachines("M3-Conv009");

        }

        public void SearchMachines(string MachineName)
        {
            if (MainManager.Instance.isTouching == false)
            {
                foreach (var machined in Machines)
                {
                    if (machined.name == MachineName)
                    {
                        machined.transform.position = ptstrans.position;
                        PlaceSound.Play();
                        machined.SetActive(true);
                    }
                    Debug.Log(machined.name.ToString());

                }
                foreach (var button in ButtonMachines)
                {
                    if (button.name == MachineName)
                    {
                        button.GetComponent<Button>().interactable = false;
                    }
                }
            }
            else { NoPlaceSound.Play(); }
        }
    }
}