using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTruck
{

        public class ParkingOverflowException : Exception
        {
            public ParkingOverflowException() : base("На парковке нет свободных мест")
            { }
        }

        public class ParkingShipNotFoundException : Exception
        {
            public ParkingShipNotFoundException(int place) : base($"Корабль на месте {place} не найден")
            { }
        }

        public class ParkingShipCannotBeAddedException : Exception
        {
            public ParkingShipCannotBeAddedException(string parking) : base($"Корабль не может быть добавлен на парковку {parking}")
            { }
        }

        public class FileFormatException : Exception
        {
            public FileFormatException(string fileName) : base($"Файл \"{fileName}\" неверно отформатирован")
            { }
        }
    
}
