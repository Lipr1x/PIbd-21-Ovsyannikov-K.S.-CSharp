using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTruck
{
    public class ParkingCollection
    {
        readonly Dictionary<string, Parking<Vehicle>> parkingStages;

        public List<string> Keys => parkingStages.Keys.ToList();

        private readonly int pictureWidth;

        private readonly int pictureHeight;

        private readonly char separator = ':';

        public ParkingCollection(int pictureWidth, int pictureHeight)
        {
            parkingStages = new Dictionary<string, Parking<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }

        public void AddParking(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                return;
            }
            parkingStages.Add(name, new Parking<Vehicle>(pictureWidth, pictureHeight));
        }

        public void DelParking(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                parkingStages.Remove(name);
            }
        }

        public Parking<Vehicle> this[string ind]
        {
            get
            {
                if(parkingStages.ContainsKey(ind))
                {
                    return parkingStages[ind];
                }
                return null;
            }
        }
        private void WriteToFile(string text, FileStream stream)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(text);
            stream.Write(info, 0, info.Length);
        }

        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }

            using (StreamWriter sw = new StreamWriter(filename, false))
            {
                sw.WriteLine($"ParkingCollection", sw);
                foreach (var level in parkingStages)
                {
                    sw.WriteLine($"Parking{separator}{level.Key}");
                    foreach (ITransport ship in level.Value)
                    {
                        if (ship.GetType().Name == "Ship")
                        {
                            sw.Write($"Plane{separator}");
                        }
                        if (ship.GetType().Name == "WarShip")
                        {
                            sw.Write($"WarShip{separator}");
                        }
                        sw.WriteLine(ship);
                    }
                }
            }
            return true;
        }

        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }

            using (StreamReader sr = new StreamReader(filename))
            {
                string line;
                if ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("ParkingCollection"))
                    {
                        parkingStages.Clear();
                    }
                    else
                    {
                        throw new FileFormatException(filename);
                    }
                    Vehicle ship = null;
                    string key = string.Empty;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Contains("Parking"))
                        {
                            key = line.Split(separator)[1];
                            parkingStages.Add(key, new Parking<Vehicle>(pictureWidth, pictureHeight));
                            continue;
                        }
                        if (string.IsNullOrEmpty(line))
                        {
                            continue;
                        }
                        if (line.Split(separator)[0] == "Ship")
                        {
                            ship = new Ship(line.Split(separator)[1]);
                        }
                        else if (line.Split(separator)[0] == "WarShip")
                        {
                            ship = new WarShip(line.Split(separator)[1]);
                        }
                        var result = parkingStages[key] + ship;
                        if (!result)
                        {
                            throw new ParkingShipCannotBeAddedException(key);
                        }
                    }
                }
                return true;
            }
        }
    }
}
