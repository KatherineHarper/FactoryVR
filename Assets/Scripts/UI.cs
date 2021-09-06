using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
// in report.....////.....
namespace VRFP
{
    public class UI : MonoBehaviour
    {
        public GameObject[] MachineList;
        //change to Text
        string UserNameInput;
        public AudioSource CameraAudio;
        public AudioSource LayoutAudio;
        JsonList jsonList = new JsonList();
        FactoryLayout layout = new FactoryLayout();
        public GameObject CanvasEdit;
        public GameObject CanvasView;
        string Date;
        public string Note;

        //VIEW UI

        string m_Message;

        public Text m_Text;

        int m_DropdownValue;

        public Dropdown mDropdown;

        void Start()
        {
            if (MainManager.Instance.isViewer == true) {
                CanvasView.SetActive(true);
                CanvasEdit.SetActive(false);
            }
         
            
            
            m_Text.text = MainManager.Instance.UserName;
            UserNameInput = MainManager.Instance.UserName;
            List<string> list = jsonList.SearchName();

            Debug.Log(list);

            mDropdown.ClearOptions();

            mDropdown.AddOptions(list);


            Debug.Log("Starting Dropdown Value : " + mDropdown.value);

        }


        public void LoadLayoutsB()
        {

            m_DropdownValue = mDropdown.value;

            m_Message = mDropdown.options[m_DropdownValue].text;

            ReadMachines(m_Message);
        }






        public void SaveMachines()
        {
            layout.ID = layout.NextID;
            layout.NextID++;
           
            layout.UserName = MainManager.Instance.UserName;
            layout.Date = System.DateTime.Now.ToString();
            

            


            foreach (var item in MachineList)
            {
                layout.machines.Add(new Machine()
                {

                    MachineName = item.name,
                    ActiveSelf = item.activeSelf,
                    Vector3 = item.GetComponent<Transform>().position,
                    YRot = item.GetComponent<Transform>().rotation.y
                });

                string json = JsonUtility.ToJson(layout);
                File.WriteAllText(Application.dataPath + "/" + UserNameInput + ".json", json);
                Debug.Log(layout.About()); ;
                CameraAudio.Play();
            }
        }






        public void LoadMachines()
        {
            ReadMachines(UserNameInput);
            LayoutAudio.Play();
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
                            machine.transform.Rotate(0.0f, mas.YRot, 0.0f, Space.Self);
                        }
                    }
                }
            }
        }
    }
}


 


    

