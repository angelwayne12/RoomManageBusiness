using RoomManage;
using RoomManageBusiness;
using RoomManageData;
using RoomManageModel;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RoomGetservices getServices = new RoomGetservices();

            var rooms = getServices.GetAllRooms();

            foreach (var item in rooms)
            {
                Console.WriteLine(item.Roomnum);
                Console.WriteLine(item.Name);
            }

            //SqlDbData.Connect();
        }
    }
}
