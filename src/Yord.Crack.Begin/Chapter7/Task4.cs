using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.Chapter7
{
    // Разработать модель автостоянки:
    // Несколько уровней, на каждом уровне много парковочных мест
    // Могут парковаться автобусы, автомобили и мотоциклы => есть парковочные места трех размеров
    // Мотоцикл можно парковать на месте любого размера
    // Автомобиль - на одном месте для авто или одном автобусном
    // Автобус - на 5ти последовательных местах для автобусов.
    //
    //
    public class Task4
    {
        public enum VehicleSize
        {
            Motorcycle,
            Compact,
            Large
        }

        public abstract class Vehicle
        {
            protected List<ParkingSpot> ParkingSpots = new List<ParkingSpot>();
            public string LicensePlate { get; protected set; }
            public int SpotsNeeded { get; protected set; }
            public VehicleSize Size { get; protected set; }

            public void ParkOnSpot(ParkingSpot s)
            {
                ParkingSpots.Add(s);
            }

            public void Leave()
            {
                ParkingSpots = new List<ParkingSpot>();
            }

            // Хватит ли места для парковки и свободно ли место
            // Проверяет только размер, не кол-во мест
            public abstract bool CanFitInSpot(ParkingSpot spot);
        }

        public class Bus : Vehicle
        {
            public Bus()
            {
                SpotsNeeded = 5;
                Size = VehicleSize.Large;
            }

            public override bool CanFitInSpot(ParkingSpot spot)
            {
                return spot.SpotSize == VehicleSize.Large;
            }
        }

        public class Car : Vehicle
        {
            public Car()
            {
                SpotsNeeded = 1;
                Size = VehicleSize.Compact;
            }

            public override bool CanFitInSpot(ParkingSpot spot)
            {
                return spot.SpotSize == VehicleSize.Large || spot.SpotSize == VehicleSize.Compact;
            }
        }

        public class Motorcycle : Vehicle
        {
            public Motorcycle()
            {
                SpotsNeeded = 1;
                Size = VehicleSize.Motorcycle;
            }

            public override bool CanFitInSpot(ParkingSpot spot)
            {
                return true;
            }
        }

        // Обертка массива уровней.
        // Позволяет отделить логику нахождения свободных мест и парковки от более общих действий.
        public class ParkingLot
        {
            private const int SpotsOnLevel = 30;
            private const int LevelsNum = 5;
            public Level[] Levels;

            public ParkingLot()
            {
                for (var i = 0; i < LevelsNum; i++)
                {
                    Levels[i] = new Level(i, SpotsOnLevel);
                }
            }

            // Попытка припарковать транспорт на парковочном месте (местах)
            public bool ParkVehicle(Vehicle vehicle)
            {
                return Levels.Any(level => level.ParkVehicle(vehicle));
            }
        }

        // Класс уровня парковки
        //
        public class Level
        {
            private const int SpotsPerRow = 10;
            private int _floor;
            private ParkingSpot[] _spots;
            public int AvailableSpots { get; private set; }

            public Level(int floor, int spotsNumber)
            {
                _floor = floor;
                var large = spotsNumber / 4;
                var motor = spotsNumber / 4;
                var compact = spotsNumber - large - motor;
                for (var i = 0; i < spotsNumber; i++)
                {
                    var size = VehicleSize.Motorcycle;
                    if (i < large)
                    {
                        size = VehicleSize.Large;
                    }
                    else
                    {
                        if (i < large + compact)
                        {
                            size = VehicleSize.Compact;
                        }
                    }

                    var row = i / SpotsPerRow;
                    var spot = new ParkingSpot(size, row, i, this);
                    _spots[i] = spot;
                }

                AvailableSpots = spotsNumber;
            }

            // Поиск места. Вернуть false в случае неудачи
            public bool ParkVehicle(Vehicle vehicle)
            {
                if (AvailableSpots < vehicle.SpotsNeeded)
                {
                    return false;
                }

                var spotNumber = FindAvailableSpots(vehicle);
                if (spotNumber < 0)
                {
                    return false;
                }

                return PartStartingAtSpot(spotNumber, vehicle);
            }

            // Парковка машины начинается с места spotNum  и занимает v.SpotsNeeded
            private bool PartStartingAtSpot(int num, Vehicle v)
            {
                var success = true;
                for (var i = num; i < num + v.SpotsNeeded; i++)
                {
                    success &= _spots[i].Park(v);
                }

                AvailableSpots -= v.SpotsNeeded;
                return success;
            }

            // поиск места для парковки. Вернуть индекс места или -1, если не нашли
            private int FindAvailableSpots(Vehicle v)
            {
                var lastRow = -1;
                var spotsFound = 0;
                for (var i = 0; i < _spots.Length; i++)
                {
                    if (lastRow != _spots[i].Row)
                    {
                        lastRow = _spots[i].Row;
                        spotsFound = 0;
                    }

                    if (_spots[i].CanFitVehicle(v))
                    {
                        spotsFound++;
                    }
                    else
                    {
                        spotsFound = 0;
                    }

                    if (spotsFound == v.SpotsNeeded)
                    {
                        return i - (spotsFound - 1);
                    }
                }

                return -1;
            }

            //  При освобождении места увеличиваем доступные места на 1
            public void SpotFreed()
            {
                AvailableSpots++;
            }
        }

        public class ParkingSpot
        {
            private Vehicle _vehicle;
            public VehicleSize SpotSize { get; }
            public int Row { get; }
            public int SpotNumber { get; }
            private Level _level;

            public ParkingSpot(VehicleSize spotSize, int row, int spotNumber, Level level)
            {
                SpotSize = spotSize;
                Row = row;
                SpotNumber = spotNumber;
                _level = level;
            }

            public bool IsAvailable => _vehicle == null;

            // Парковка ТС на заданном месте. True при успехе
            public bool Park(Vehicle v)
            {
                if (!CanFitVehicle(v))
                {
                    return false;
                }
                v.Leave();
                _vehicle = v;
                return true;
            }

            public void RemoveVehicle()
            {
                _level.SpotFreed();
                _vehicle = null;
            }

            public bool CanFitVehicle(Vehicle vehicle)
            {
                return IsAvailable && vehicle.CanFitInSpot(this);
            }
        }
    }
}
