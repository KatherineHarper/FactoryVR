using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
//todo
//rolling number
//catch if no name bootui after enter button

//
namespace VRFP
{
    public class UI : MonoBehaviour
    {
        public GameObject[] MachineList;
        //change to Text
         string UserNameInput = MainManager.Instance.UserName;
       
        JsonList jsonList = new JsonList();
        FactoryLayout layout = new FactoryLayout();
        //VIEW UI

        string m_Message;

        public Text m_Text;

        int m_DropdownValue;

        public Dropdown mDropdown;

        void Start()
        {

            List<string> list = jsonList.SearchName();

            Debug.Log(list);

            mDropdown.ClearOptions();

            mDropdown.AddOptions(list);


            Debug.Log("Starting Dropdown Value : " + mDropdown.value);
        }
        public void LoadLayoutsB()
        {
            //Keep the current index of the Dropdown in a variable
            m_DropdownValue = mDropdown.value;
            //Change the message to say the name of the current Dropdown selection using the value
            m_Message = mDropdown.options[m_DropdownValue].text;
            //Change the onscreen Text to reflect the current Dropdown selection
            ReadMachines(m_Message);
        }

        public void MakeMachines()
        {

            //layout.UserName = MainManager.Instance.UserName;
            layout.ID = 64;

            foreach (var item in MachineList)
            {
                layout.machines.Add(new Machine()
                {

                    MachineName = item.name,
                    ActiveSelf = item.activeSelf,
                    Vector3 = item.GetComponent<Transform>().position
                });

                string json = JsonUtility.ToJson(layout);
                File.WriteAllText(Application.dataPath + "/" + UserNameInput + ".json", json);
                Debug.Log(layout.About()); ;
            }
        }







        public void PlaceMachines()
        {
            ReadMachines(UserNameInput);
        }


        public void ReadMachines(string NameOfUser)
        {
            string path = Application.dataPath + "/" + NameOfUser + ".json";
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                FactoryLayout data = JsonUtility.FromJson<FactoryLayout>(json);
                foreach (var machine in MachineList)
                {
                    foreach (var mas in data.machines)
                    {
                        if (machine.name == mas.MachineName)
                        {

                            machine.transform.position = mas.Vector3;
                            machine.SetActive(mas.ActiveSelf);
                        }
                    }
                }



            }
        }
    }

}


    

