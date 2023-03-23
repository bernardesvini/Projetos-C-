using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioSecao6._1
{
    internal class Room
    {

        public int RoomNumber { get; set; }
        public string RenterName { get; set; }
        public string RenterEmail { get; set; }

        public override string ToString()
        {
            return RoomNumber + ": "  + RenterName + ", " + RenterEmail;
        }

    }
}
