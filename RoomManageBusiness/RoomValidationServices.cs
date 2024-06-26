using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoomManageData;
using RoomManageModel;

namespace RoomManageBusiness
{
    public class RoomValidationServices
    {
        RoomGetservices getservices = new RoomGetservices();

        public bool CheckIfNameExists(string Name)
        {
            bool result = getservices.GetName(Name) != null;
            return result;
        }
    }
}
