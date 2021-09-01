
using System.Collections.Generic;
using UnityEngine;
namespace VRFP
{
    [System.Serializable]
    public class FactoryLayout
    {

        
        public int ID;

        public List<Machine> machines = new List<Machine>();

        public string About()
        {
            string Info = "";

            Info += "User Name " + MainManager.Instance.UserName + " Mesurements " + ID + "“\r\n”";
            foreach (var item in machines)
            {
                Info += "username " + MainManager.Instance.UserName + "“\r\n”";
                Info += "Machine Name " + item.MachineName + "“\r\n”";
                Info += "Machine Active " + item.ActiveSelf + "“\r\n”";
                Info += "Machine Vector " + item.Vector3 + "“\r\n”";
            }
            return Info;
        }

    }
}
//to seaerch names
//https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-5.0