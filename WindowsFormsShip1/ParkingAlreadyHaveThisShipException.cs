using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTruck
{
	class ParkingAlreadyHaveThisShipException : Exception
	{
		public ParkingAlreadyHaveThisShipException() : base("На парковке уже есть такой " + "корабль")
		{ }
	}
}
