
using System.Collections.Generic;
using UnityEngine;
using VRFP;

namespace VRFP
{
    [System.Serializable]
    public class FactoryLayout
    {

        public int NextID = 0;
      
        public int ID;
        public string UserName;
        public string Date;

        public List<Machine> machines = new List<Machine>();

       

        public string About()
        {
            string Info = "";
            Info += "Date saved " + Date + "“\r\n”";
            Info += "ID " + NextID + "“\r\n”";
            Info += "User Name " + MainManager.Instance.UserName + " Mesurements " + ID + "“\r\n”";
            // Info += "Note " + Notes + "“\r\n”";
            foreach (var item in machines)
            {
                Info += "username " + MainManager.Instance.UserName + "“\r\n”";
                Info += "Machine Name " + item.MachineName + "“\r\n”";
                Info += "Machine Id " + item.Id + "“\r\n”";
                Info += "Machine Active " + item.ActiveSelf + "“\r\n”";
                Info += "Machine Vector " + item.Vector3 + "“\r\n”";
                Info += "Machine Rotation y " + item.YRot + "“\r\n”";
            }
            return Info;
        }

    }

}
//to seaerch names
//https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-5.0