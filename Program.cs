using System;
using System.Collections.Generic;

// Абстрактный класс для транспортного средства
public abstract class Transport
{
    public abstract string Name { get; }
    //public abstract bool IsGround { get; }
    //public abstract bool IsAir { get; }
    public abstract int MovementSpeed { get; }

    public abstract void Move(int distance, int index);
    public abstract float TotalTime { get; }
    public abstract void Rest();
}

// Наземное транспортное средство
public abstract class GroundTransport : Transport
{
    public abstract int TimeDrive { get; }
    //public abstract float TimeRest { get; }
    //public override bool IsGround => true;
    //public override bool IsAir => false;
}

// Воздушное транспортное средство
public abstract class AirTransport : Transport
{
    public abstract float AccelerationCoefficient { get; }
    //public override bool IsAir => true;
}

// Реализация класса для конкретного вида транспорта

public class BabaYagaStupa : AirTransport
{
    private float time;

    public override string Name => "Ступа Бабы Яги";
    public override int MovementSpeed => 20;
    public override float AccelerationCoefficient => 0.05f;
    //float time = 0;
    //public override float TotalTime => 0;
    public override void Move(int distance, int index)
    {
        float acceleration = AccelerationCoefficient * distance; // ускорение = коэффициент ускорения * расстояние
        time = MovementSpeed / acceleration; // время движения = скорость / ускорение
        //public override int TotalTime => MovementSpeed / acceleration;
        
    Console.WriteLine($"{Name} пролетел расстояние {distance} условных единиц за {time} часов.");
        //Console.WriteLine($"Транспорт {Name} движется со скоростью {MovementSpeed} условных единиц.");
    }
    public override float TotalTime => time;
    public override void Rest()
    {
        Console.WriteLine($"Транспорт {Name} отдыхает.");
    }
}

public class Broom : AirTransport
{
    public override string Name => "Метла";
    public override int MovementSpeed => 25;
    public override float AccelerationCoefficient => 0.01f;
    private float time;
    public override void Move(int distance, int index)
    {
        float acceleration = AccelerationCoefficient * distance; // ускорение = коэффициент ускорения * расстояние
        time = MovementSpeed / acceleration; // время движения = скорость / ускорение

        Console.WriteLine($"{Name} пролетел расстояние {distance} условных единиц за {time} часов.");
        //Console.WriteLine($"Транспорт {Name} движется со скоростью {MovementSpeed} условных единиц.");
    }
    public override float TotalTime => time;
    public override void Rest()
    {
        Console.WriteLine($"Транспорт {Name} отдыхает.");
    }
}

public class Carpet : AirTransport
{
    public override string Name => "Ковер-самолет";
    public override int MovementSpeed => 27;
    public override float AccelerationCoefficient => 0.006f;
    private float time;
    public override void Move(int distance, int index)
    {
        float acceleration = AccelerationCoefficient * distance; // ускорение = коэффициент ускорения * расстояние
        time = MovementSpeed / acceleration; // время движения = скорость / ускорение

        Console.WriteLine($"{Name} пролетел расстояние {distance} условных единиц за {time} часов.");
        //Console.WriteLine($"Транспорт {Name} движется со скоростью {MovementSpeed} условных единиц.");
    }
    public override float TotalTime => time;
    public override void Rest()
    {
        Console.WriteLine($"Транспорт {Name} отдыхает.");
    }
}

public class Ship : AirTransport
{
    public override string Name => "Летучий корабль";
    public override int MovementSpeed => 35;
    public override float AccelerationCoefficient => 0.01f;
    private float time;
    public override void Move(int distance, int index)
    {
        float acceleration = AccelerationCoefficient * distance; // ускорение = коэффициент ускорения * расстояние
        time = MovementSpeed / acceleration; // время движения = скорость / ускорение

        Console.WriteLine($"{Name} пролетел расстояние {distance} условных единиц за {time} часов.");
        //Console.WriteLine($"Транспорт {Name} движется со скоростью {MovementSpeed} условных единиц.");
    }
    public override float TotalTime => time;
    public override void Rest()
    {
        Console.WriteLine($"Транспорт {Name} отдыхает.");
    }
}

public class Boots : GroundTransport
{
    public override string Name => "Сапоги-скороходы";
    public override int MovementSpeed => 15;
    public override int TimeDrive => 90;
    //public override float TimeRest => 4;
    //public override float AccelerationCoefficient => 0f;
    private float time;
    private float TimeRest;
    public override void Move(int distance, int index)
    {
        if (index == 1)
            TimeRest = 2;
        if (index == 2)
            TimeRest = 4;
        if (index == 3)
            TimeRest = 5;
        if (index == 4)
            TimeRest = 10;
        if (index == 5)
            TimeRest = 11;
        if (index == 6)
            TimeRest = 9;
        if (index == 7)
            TimeRest = 7;
        if (index == 8)
            TimeRest = 2.2f;
        int totalTime = distance / MovementSpeed; // время движения = расстояние / скорость
        int restCount = totalTime / TimeDrive; // количество остановок на отдых = общее время / время отдыха
        time = totalTime + restCount * TimeRest;
        Console.WriteLine($"{Name} проехал расстояние {distance} условных единиц за {time} часов, сделав {restCount} остановки на отдых.");
        //Console.WriteLine($"Транспорт {Name} движется со скоростью {MovementSpeed} условных единиц.");
    }
    public override float TotalTime => time;
    public override void Rest()
    {
        Console.WriteLine($"Транспорт {Name} отдыхает.");
    }
}

public class Coach : GroundTransport
{
    public override string Name => "Карета-тыква";
    public override int MovementSpeed => 10;
    public override int TimeDrive => 25;
    //public override float TimeRest => 4;
    //public override float AccelerationCoefficient => 0f;
    private float time;
    private float TimeRest;
    public override void Move(int distance, int index)
    {
        if (index == 1)
            TimeRest = 1;
        if (index == 2)
            TimeRest = 1.9f;
        if (index == 3)
            TimeRest = 2.5f;
        if (index == 4)
            TimeRest = 10;
        if (index == 5)
            TimeRest = 1.2f;
        if (index == 6)
            TimeRest = 21;
        if (index == 7)
            TimeRest = 11;
        if (index == 8)
            TimeRest = 2.7f;
        int totalTime = distance / MovementSpeed; // время движения = расстояние / скорость
        int restCount = totalTime / TimeDrive; // количество остановок на отдых = общее время / время отдыха
        time = totalTime + restCount * TimeRest;
        Console.WriteLine($"{Name} проехал расстояние {distance} условных единиц за {time} часов, сделав {restCount} остановки на отдых.");
    }
    public override float TotalTime => time;
    public override void Rest()
    {
        Console.WriteLine($"Транспорт {Name} отдыхает.");
    }
}
public class Hut : GroundTransport
{
    public override string Name => "Избушка на курьих ножках";
    public override int MovementSpeed => 19;
    public override int TimeDrive => 100;
    //public override float TimeRest => 4;
    //public override float AccelerationCoefficient => 0f;
    private float time;
    private float TimeRest;
    public override void Move(int distance, int index)
    {
        if (index == 1)
            TimeRest = 5.2f;
        if (index == 2)
            TimeRest = 3.9f;
        if (index == 3)
            TimeRest = 5;
        if (index == 4)
            TimeRest = 1;
        if (index == 5)
            TimeRest = 1.2f;
        if (index == 6)
            TimeRest = 22;
        if (index == 7)
            TimeRest = 11;
        if (index == 8)
            TimeRest = 7;
        int totalTime = distance / MovementSpeed; // время движения = расстояние / скорость
        int restCount = totalTime / TimeDrive; // количество остановок на отдых = общее время / время отдыха
        time = totalTime + restCount * TimeRest;
        Console.WriteLine($"{Name} проехал расстояние {distance} условных единиц за {time} часов, сделав {restCount} остановки на отдых.");
    }
    public override float TotalTime => time;
    public override void Rest()
    {
        Console.WriteLine($"Транспорт {Name} отдыхает.");
    }
}
public class Centaur : GroundTransport
{
    public override string Name => "Кентавр";
    public override int MovementSpeed => 17;
    public override int TimeDrive => 77;
    //public override float TimeRest => 4;
    //public override float AccelerationCoefficient => 0f;
    private float time;
    private float TimeRest;
    public override void Move(int distance, int index)
    {
        if (index == 1)
            TimeRest = 0.7f;
        if (index == 2)
            TimeRest = 1;
        if (index == 3)
            TimeRest = 2.5f;
        if (index == 4)
            TimeRest = 1.5f;
        if (index == 5)
            TimeRest = 2;
        if (index == 6)
            TimeRest = 2.9f;
        if (index == 7)
            TimeRest = 11;
        if (index == 8)
            TimeRest = 7;
        int totalTime = distance / MovementSpeed; // время движения = расстояние / скорость
        int restCount = totalTime / TimeDrive; // количество остановок на отдых = общее время / время отдыха
        time = totalTime + restCount * TimeRest;
        Console.WriteLine($"{Name} проехал расстояние {distance} условных единиц за {time} часов, сделав {restCount} остановки на отдых.");
    }
    public override float TotalTime => time;
    public override void Rest()
    {
        Console.WriteLine($"Транспорт {Name} отдыхает.");
    }
}

// Реализация класса для симулятора гонок

public class RaceSimulator
{
    private List<Transport> registeredTransports;
    private int raceDistance;
    private int raceIndex;
    private bool isRaceRunning;

    public RaceSimulator(int distance)
    {
        registeredTransports = new List<Transport>();
        raceDistance = distance;
        isRaceRunning = false;
        
    }

    public void RegisterTransport(Transport transport, int index)
    {
        raceIndex = index;
        if (isRaceRunning)
        {
            Console.WriteLine("Невозможно зарегистрировать транспортное средство во время гонки.");
            return;
        }

        /*if (transport.IsGround && !registeredTransports.Exists(t => t.IsAir))
        {
            registeredTransports.Add(transport);
            Console.WriteLine($"Транспорт {transport.Name} зарегестрирован.");
        }
        else if (transport.IsAir && !registeredTransports.Exists(t => t.IsGround))
        {
            registeredTransports.Add(transport);
            Console.WriteLine($"Транспорт {transport.Name} зарегестрирован.");
        }*/
        //if (registeredTransports.Find(transport.Name)){
        //Console.WriteLine(registeredTransports.Find(transport);
        string str = transport.Name;
        if (registeredTransports.Contains(transport) == false) { 
            registeredTransports.Add(transport);
            Console.WriteLine($"Транспорт {transport.Name} зарегестрирован под номером {raceIndex + 1}."); 
        }else
        {
            Console.WriteLine("Невозможно зарегистрировать транспортное средство для данной гонки.");
        }
    }

    public void StartRace()
    {
        if (isRaceRunning)
        {
            Console.WriteLine();
            Console.WriteLine("Гонка уже запущена.");
            return;
        }

        if (registeredTransports.Count < 2)
        {
            Console.WriteLine();
            Console.WriteLine("Недостаточно зарегистрированных транспортных средств для запуска гонки.");
            return;
        }

        isRaceRunning = true;
        Console.WriteLine();
        Console.WriteLine("Гонка началась!");
        raceIndex = 0;
        foreach (Transport transport in registeredTransports)
        {
            raceIndex++;
            transport.Move(raceDistance, raceIndex);
        }

        Transport winner = registeredTransports[0];
        foreach (Transport transport in registeredTransports)
        {
            if (transport.TotalTime < winner.TotalTime)
            {
                winner = transport;
            }
        }
        Console.WriteLine();
        Console.WriteLine($"Победил транспорт {winner.Name}!  {winner.TotalTime}");
        isRaceRunning = false;
    }
}

// Пример использования

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Для создания гонки введите ее расстояние: ");
        Console.WriteLine();
        int flag = Convert.ToInt32(Console.ReadLine());
        RaceSimulator raceSimulator = new RaceSimulator(flag);
        Console.WriteLine();
        Console.WriteLine("Выберите тип гонки:");
        Console.WriteLine();
        Console.WriteLine("1. Наземный транспорт");
        Console.WriteLine("2. Воздушный транспорт");
        Console.WriteLine("3. Смешанный транспорт");
        Console.WriteLine();
        Console.WriteLine("Выберите номер гонки:");
        Console.WriteLine();
        string fl = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Гонка создана!");
        Console.WriteLine();
        switch (fl)
        {
            case "1":
                Console.WriteLine();
                Console.WriteLine("Введите количество транспорта, участвующих в гонке (всего возможно 4):");
                Console.WriteLine();
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Доступные транспорта:");
                Console.WriteLine();
                Console.WriteLine("1. Сапоги-скороходы");
                Console.WriteLine("2. Карета-тыква");
                Console.WriteLine("3. Избушка на курьих ношках");
                Console.WriteLine("4. Кентавр");
                Console.WriteLine();
                Console.WriteLine("Введите номера транспорта для регистрации в гонке, начиная новый транспор с новой строки:");
                // Создание и регистрация транспортных средств на гонку
                for (int i = 0; i<n; i++)
                {
                    string fl_1 = Console.ReadLine();
                    if(fl_1 == "1")
                    {
                        Transport boots = new Boots();
                        raceSimulator.RegisterTransport(boots, i);
                    }else if (fl_1 == "2")
                    {
                        Transport coach = new Coach();
                        raceSimulator.RegisterTransport(coach, i);
                    }else if (fl_1 == "3")
                    {
                        Transport hut = new Hut();
                        raceSimulator.RegisterTransport(hut, i);
                    }else if (fl_1 == "4")
                    {
                        Transport centaur = new Centaur();
                        raceSimulator.RegisterTransport(centaur, i);
                    }else
                        Console.WriteLine("Данный транспорт не может быть зарегестрировано!!!");
                }
                // Запуск гонки
                raceSimulator.StartRace();
                break;
            case "2":
                Console.WriteLine();
                Console.WriteLine("Введите количество транспорта, участвующих в гонке (всего возможно 4):");
                Console.WriteLine();
                int n2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Доступные транспорта:");
                Console.WriteLine();
                Console.WriteLine("1. Ступа Бабы Яги");
                Console.WriteLine("2. Метла");
                Console.WriteLine("3. Карета-тыква");
                Console.WriteLine("4. Летучий корабль");
                Console.WriteLine();
                Console.WriteLine("Введите номера транспорта для регистрации в гонке, начиная новый транспор с новой строки:");
                // Создание и регистрация транспортных средств на гонку
                for (int i = 0; i < n2; i++)
                {
                    string fl_2 = Console.ReadLine();
                    if (fl_2 == "1")
                    {
                        Transport stupa = new BabaYagaStupa();
                        raceSimulator.RegisterTransport(stupa, i);
                    }
                    else if (fl_2 == "2")
                    {
                        Transport broom = new Broom();
                        raceSimulator.RegisterTransport(broom, i);
                    }
                    else if (fl_2 == "3")
                    {
                        Transport carpet = new Carpet();
                        raceSimulator.RegisterTransport(carpet, i);
                    }
                    else if (fl_2 == "4")
                    {
                        Transport ship = new Ship();
                        raceSimulator.RegisterTransport(ship, i);
                    }
                    else
                        Console.WriteLine("Данный транспорт не может быть зарегестрировано!!!");
                }
                // Запуск гонки
                raceSimulator.StartRace();
                break;
            case "3":
                Console.WriteLine();
                Console.WriteLine("Введите количество транспорта, участвующих в гонке (всего возможно 8):");
                Console.WriteLine();
                int n3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Доступные транспорта:");
                Console.WriteLine();
                Console.WriteLine("1. Ступа Бабы Яги");
                Console.WriteLine("2. Метла");
                Console.WriteLine("3. Карета-тыква");
                Console.WriteLine("4. Летучий корабль");
                Console.WriteLine("5. Сапоги-скороходы");
                Console.WriteLine("6. Карета-тыква");
                Console.WriteLine("7. Избушка на курьих ношках");
                Console.WriteLine("8. Кентавр");
                Console.WriteLine();
                Console.WriteLine("Введите номера транспорта для регистрации в гонке, начиная новый транспор с новой строки:");
                // Создание и регистрация транспортных средств на гонку
                for (int i = 0; i < n3; i++)
                {
                    string fl_3 = Console.ReadLine();
                    if (fl_3 == "1")
                    {
                        Transport stupa = new BabaYagaStupa();
                        raceSimulator.RegisterTransport(stupa, i);
                    }
                    else if (fl_3 == "2")
                    {
                        Transport broom = new Broom();
                        raceSimulator.RegisterTransport(broom, i);
                    }
                    else if (fl_3 == "3")
                    {
                        Transport carpet = new Carpet();
                        raceSimulator.RegisterTransport(carpet, i);
                    }
                    else if (fl_3 == "4")
                    {
                        Transport ship = new Ship();
                        raceSimulator.RegisterTransport(ship, i);
                    }
                    else if(fl_3 == "5")
                    {
                        Transport boots = new Boots();
                        raceSimulator.RegisterTransport(boots, i);
                    }else if (fl_3 == "6")
                    {
                        Transport coach = new Coach();
                        raceSimulator.RegisterTransport(coach, i);
                    }
                    else if (fl_3 == "7")
                    {
                        Transport hut = new Hut();
                        raceSimulator.RegisterTransport(hut, i);
                    }
                    else if (fl_3 == "8")
                    {
                        Transport centaur = new Centaur();
                        raceSimulator.RegisterTransport(centaur, i);
                    }
                    else
                        Console.WriteLine("Данный транспорт не может быть зарегестрировано!!!");
                }
                // Запуск гонки
                raceSimulator.StartRace();
                break;
        }

        // Создание транспортных средств
        /*Transport stupa = new BabaYagaStupa();
        Transport broom = new Broom();
        Transport ship = new Ship();
        Transport s = new Coach();

        // Регистрация транспортных средств на гонку
        raceSimulator.RegisterTransport(stupa);
        raceSimulator.RegisterTransport(broom);
        raceSimulator.RegisterTransport(ship);
        raceSimulator.RegisterTransport(s);

        // Запуск гонки
        raceSimulator.StartRace();*/
    }
}
