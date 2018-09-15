using System;
namespace puma560
{
    class Program
    {
        public double[,] array1 = new double[6, 4];
        public double[,] array2 = new double[4, 4];
        public double Schet(double t1, double t2, double t3, double t4, double t5, double t6, double a2, double a3, double d3, double d4,
            out double r12, out double r13, out double px, out double r21, out double r22, out double r23, out double py, out double r31, out double r32, out double r33, out double pz)
        {
            Program program = new Program();
            t1 = t1 * Math.PI / 180;
            t2 = t2 * Math.PI / 180;
            t3 = t3 * Math.PI / 180;
            t4 = t4 * Math.PI / 180;
            t5 = t5 * Math.PI / 180;
            t6 = t6 * Math.PI / 180;//формулы для расчета положений звена
            double r11 = Math.Round(Math.Cos(t1) * ((Math.Cos(t2) * Math.Cos(t3) - Math.Sin(t2) * Math.Sin(t3)) * (Math.Cos(t4) * Math.Cos(t5) * Math.Cos(t6) - Math.Sin(t4) * Math.Sin(t5)) - (Math.Cos(t2) * Math.Sin(t3) - Math.Sin(t2) * Math.Cos(t3)) * Math.Sin(t5) * Math.Cos(t5)) + Math.Sin(t1) * (Math.Sin(t4) * Math.Cos(t5) * Math.Cos(t6) + Math.Cos(t4) * Math.Sin(t6)), 4);
            r21 = Math.Round(Math.Sin(t1) * ((Math.Cos(t2) * Math.Cos(t3) - Math.Sin(t2) * Math.Sin(t3)) * (Math.Cos(t4) * Math.Cos(t5) * Math.Cos(t6) - Math.Sin(t4) * Math.Sin(t6)) - (Math.Cos(t2) * Math.Sin(t3) - Math.Sin(t2) * Math.Cos(t3)) * Math.Sin(t5) * Math.Cos(t6)) - Math.Cos(t1) * (Math.Sin(t4) * Math.Cos(t5) * Math.Cos(t6) + Math.Cos(t4) * Math.Sin(t6)), 4);
            r31 = Math.Round((-1) * (Math.Cos(t2) * Math.Sin(t3) - Math.Sin(t2) * Math.Cos(t3)) * (Math.Cos(t4) * Math.Cos(t5) * Math.Cos(t6) - Math.Sin(t4) * Math.Sin(t6)) - (Math.Cos(t2) * Math.Cos(t3) - Math.Sin(t2) * Math.Sin(t3)) * Math.Sin(t5) * Math.Cos(t6), 4);
            r12 = Math.Round(Math.Cos(t1) * ((Math.Cos(t2) * Math.Cos(t3) - Math.Sin(t2) * Math.Sin(t3)) * ((-1) * Math.Cos(t4) * Math.Cos(t5) * Math.Sin(t6) - Math.Sin(t4) * Math.Cos(t6)) + (Math.Cos(t2) * Math.Sin(t3) - Math.Sin(t2) * Math.Cos(t3)) * Math.Sin(t5) * Math.Sin(t6)) + Math.Sin(t1) * (Math.Cos(t4) * Math.Cos(t6) - Math.Sin(t4) * Math.Cos(t5) * Math.Sin(t6)), 4);
            r22 = Math.Round(Math.Sin(t1) * ((Math.Cos(t2) * Math.Cos(t3) - Math.Sin(t2) * Math.Sin(t3)) * ((-1) * Math.Cos(t4) * Math.Cos(t5) * Math.Sin(t6) - Math.Sin(t4) * Math.Cos(t6)) + (Math.Cos(t2) * Math.Sin(t3) - Math.Sin(t2) * Math.Cos(t3)) * Math.Sin(t5) * Math.Sin(t6)) - Math.Cos(t1) * (Math.Cos(t4) * Math.Cos(t6) - Math.Sin(t4) * Math.Cos(t5) * Math.Sin(t6)), 4);
            r32 = Math.Round((-1) * (Math.Cos(t2) * Math.Sin(t3) - Math.Sin(t2) * Math.Cos(t3)) * ((-1) * Math.Cos(t4) * Math.Cos(t5) * Math.Sin(t6) - Math.Sin(t4) * Math.Cos(t6)) + (Math.Cos(t2) * Math.Cos(t3) - Math.Sin(t2) * Math.Sin(t3)) * Math.Sin(t5) * Math.Sin(t6), 4);
            r13 = Math.Round((-1) * Math.Cos(t1) * ((Math.Cos(t2) * Math.Cos(t3) - Math.Sin(t2) * Math.Sin(t3)) * Math.Cos(t4) * Math.Sin(t5) + (Math.Cos(t2) * Math.Sin(t3) - Math.Sin(t2) * Math.Cos(t3)) * Math.Cos(t5)) - Math.Sin(t1) * Math.Sin(t4) * Math.Sin(t5), 4);
            r23 = Math.Round((-1) * Math.Sin(t1) * ((Math.Cos(t2) * Math.Cos(t3) - Math.Sin(t2) * Math.Sin(t3)) * Math.Cos(t4) * Math.Sin(t5) + (Math.Cos(t2) * Math.Sin(t3) - Math.Sin(t2) * Math.Cos(t3)) * Math.Cos(t5)) + Math.Cos(t1) * Math.Sin(t4) * Math.Sin(t5), 4);
            r33 = Math.Round((Math.Cos(t2) * Math.Sin(t3) - Math.Sin(t2) * Math.Cos(t3)) * Math.Cos(t4) * Math.Sin(t5) - (Math.Cos(t2) * Math.Cos(t3) - Math.Sin(t2) * Math.Sin(t3)) * Math.Cos(t5), 4);
            px = Math.Round(Math.Cos(t1) * (a2 * Math.Cos(t2) + a3 * (Math.Cos(t2) * Math.Cos(t3) - Math.Sin(t2) * Math.Sin(t3)) - d4 * (Math.Cos(t2) * Math.Sin(t3) - Math.Sin(t2) * Math.Cos(t3))) - d3 * Math.Sin(t1), 4);
            py = Math.Round(Math.Sin(t1) * (a2 * Math.Cos(t2) + a3 * (Math.Cos(t2) * Math.Cos(t3) - Math.Sin(t2) * Math.Sin(t3)) - d4 * (Math.Cos(t2) * Math.Sin(t3) - Math.Sin(t2) * Math.Cos(t3))) + d3 * Math.Cos(t1), 4);
            pz = Math.Round((-1) * a3 * (Math.Cos(t2) * Math.Sin(t3) - Math.Sin(t2) * Math.Cos(t3)) - a2 * Math.Sin(t2) - d4 * (Math.Cos(t2) * Math.Cos(t3) - Math.Sin(t2) * Math.Sin(t3)), 4);
            return (r11);
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            double check; //установка начальных условий
            program.array1[0, 0] = 0;
            program.array1[0, 1] = 0;
            program.array1[0, 2] = 0;
            program.array1[0, 3] = 0;
            program.array1[1, 0] = 0;
            program.array1[1, 1] = 0;
            program.array1[1, 2] = 0;
            program.array1[1, 3] = 0;
            program.array1[2, 0] = 0;
            program.array1[2, 1] = 17;
            program.array1[2, 2] = 9.2;
            program.array1[2, 3] = 0;
            program.array1[3, 0] = 0;
            program.array1[3, 1] = 0;
            program.array1[3, 2] = 17.05;
            program.array1[3, 3] = 0;
            program.array1[4, 0] = 0;
            program.array1[4, 1] = 0;
            program.array1[4, 2] = 0;
            program.array1[4, 3] = 0;
            program.array1[5, 0] = 0;
            program.array1[5, 1] = 0;
            program.array1[5, 2] = 0;
            program.array1[5, 3] = 0;
            program.array2[3, 0] = 0;
            program.array2[3, 1] = 0;
            program.array2[3, 2] = 0;
            program.array2[3, 3] = 1;
            while (true)
            {
                Console.WriteLine("Введите номер звена, которое необходимо повернуть\t");
                Console.WriteLine("Для того что бы вывести на экран текущие положения звеньев нажмите 7\t");
                Console.WriteLine("Для того что бы вывести на экран текущие углы поворота звеньев нажмите 8\t");

                int switchcase = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
                switch (switchcase)
                {
                    case 1:
                        Console.WriteLine("Введите угол на который необходимо повернуть звено\t");
                        check = Convert.ToDouble(Console.ReadLine());
                        if (check + program.array1[0, 3] > -160 && check + program.array1[0, 3] < 160)
                        {
                            program.array1[0, 3] = check + program.array1[0, 3];
                            program.array2[0, 0] = program.Schet(program.array1[0, 3], program.array1[1, 3], program.array1[2, 3], program.array1[3, 3], program.array1[4, 3], program.array1[5, 3], program.array1[2, 1], program.array1[3, 1], program.array1[2, 2], program.array1[3, 2],
                            out program.array2[0, 1], out program.array2[0, 2], out program.array2[0, 3], out program.array2[1, 0], out program.array2[1, 1], out program.array2[1, 2], out program.array2[1, 3], out program.array2[2, 0], out program.array2[2, 1], out program.array2[2, 2], out program.array2[2, 3]);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("звено не может повернуться на этот угол\t");
                            Console.WriteLine("допустимые углы для этого звена -160, 160\t");
                            Console.WriteLine("текущий угол = " + program.array1[3, 0]);
                            break;
                        }
                    case 2:
                        Console.WriteLine("Введите угол на который необходимо повернуть звено\t");
                        check = Convert.ToDouble(Console.ReadLine());
                        if (check + program.array1[1, 3] > -225 && check + program.array1[1, 3] < 45)
                        {
                            program.array1[1, 3] = check + program.array1[1, 3];
                            program.array2[0, 0] = program.Schet(program.array1[0, 3], program.array1[1, 3], program.array1[2, 3], program.array1[3, 3], program.array1[4, 3], program.array1[5, 3], program.array1[2, 1], program.array1[3, 1], program.array1[2, 2], program.array1[3, 2],
                            out program.array2[0, 1], out program.array2[0, 2], out program.array2[0, 3], out program.array2[1, 0], out program.array2[1, 1], out program.array2[1, 2], out program.array2[1, 3], out program.array2[2, 0], out program.array2[2, 1], out program.array2[2, 2], out program.array2[2, 3]);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("звено не может повернуться на этот угол\t");
                            Console.WriteLine("допустимые углы для этого звена -225, 45\t");
                            Console.WriteLine("текущий угол = " + program.array1[3, 1]);
                            break;
                        }
                    case 3:
                        Console.WriteLine("Введите угол на необходимо надо повернуть звено\t");
                        check = Convert.ToDouble(Console.ReadLine());
                        if (check + program.array1[2, 3] > -45 && check + program.array1[2, 3] < 225)
                        {
                            program.array1[2, 3] = check + program.array1[2, 3];
                            program.array2[0, 0] = program.Schet(program.array1[0, 3], program.array1[1, 3], program.array1[2, 3], program.array1[3, 3], program.array1[4, 3], program.array1[5, 3], program.array1[2, 1], program.array1[3, 1], program.array1[2, 2], program.array1[3, 2],
                            out program.array2[0, 1], out program.array2[0, 2], out program.array2[0, 3], out program.array2[1, 0], out program.array2[1, 1], out program.array2[1, 2], out program.array2[1, 3], out program.array2[2, 0], out program.array2[2, 1], out program.array2[2, 2], out program.array2[2, 3]);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("звено не может повернуться на этот угол\t");
                            Console.WriteLine("допустимые углы для этого звена -45, 225\t");
                            Console.WriteLine("текущий угол = " + program.array1[3, 2]);
                            break;
                        }
                    case 4:
                        Console.WriteLine("Введите угол на который необходимо повернуть звено\t");
                        check = Convert.ToDouble(Console.ReadLine());
                        if (check + program.array1[3, 3] > -110 && check + program.array1[3, 3] < 110)
                        {
                            program.array1[3, 3] = check + program.array1[3, 3];
                            program.array2[0, 0] = program.Schet(program.array1[0, 3], program.array1[1, 3], program.array1[2, 3], program.array1[3, 3], program.array1[4, 3], program.array1[5, 3], program.array1[2, 1], program.array1[3, 1], program.array1[2, 2], program.array1[3, 2],
                            out program.array2[0, 1], out program.array2[0, 2], out program.array2[0, 3], out program.array2[1, 0], out program.array2[1, 1], out program.array2[1, 2], out program.array2[1, 3], out program.array2[2, 0], out program.array2[2, 1], out program.array2[2, 2], out program.array2[2, 3]);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("звено не может повернуться на этот угол\t");
                            Console.WriteLine("допустимые углы для этого звена -110, 110\t");
                            Console.WriteLine("текущий угол = \t" + program.array1[3, 3]);
                            break;
                        }
                    case 5:
                        Console.WriteLine("Введите угол на который необходимо повернуть звено\t");
                        check = Convert.ToDouble(Console.ReadLine());
                        if (check + program.array1[4, 3] > -100 && check + program.array1[4, 3] < 100)
                        {
                            program.array1[4, 3] = check + program.array1[4, 3];
                            program.array2[0, 0] = program.Schet(program.array1[0, 3], program.array1[1, 3], program.array1[2, 3], program.array1[3, 3], program.array1[4, 3], program.array1[5, 3], program.array1[2, 1], program.array1[3, 1], program.array1[2, 2], program.array1[3, 2],
                            out program.array2[0, 1], out program.array2[0, 2], out program.array2[0, 3], out program.array2[1, 0], out program.array2[1, 1], out program.array2[1, 2], out program.array2[1, 3], out program.array2[2, 0], out program.array2[2, 1], out program.array2[2, 2], out program.array2[2, 3]);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("звено не может повернуться на этот угол\t");
                            Console.WriteLine("допустимые углы для этого звена -100, 100\t");
                            Console.WriteLine("текущий угол = " + program.array1[3, 4]);
                            break;
                        }
                    case 6:
                        Console.WriteLine("Введите угол на который необходимо повернуть звено\t");
                        check = Convert.ToDouble(Console.ReadLine());
                        if (check + program.array1[5, 3] > -266 && check + program.array1[5, 3] < 266)
                        {
                            program.array1[5, 3] = check + program.array1[5, 3];
                            program.array2[0, 0] = program.Schet(program.array1[0, 3], program.array1[1, 3], program.array1[2, 3], program.array1[3, 3], program.array1[4, 3], program.array1[5, 3], program.array1[2, 1], program.array1[3, 1], program.array1[2, 2], program.array1[3, 2],
                            out program.array2[0, 1], out program.array2[0, 2], out program.array2[0, 3], out program.array2[1, 0], out program.array2[1, 1], out program.array2[1, 2], out program.array2[1, 3], out program.array2[2, 0], out program.array2[2, 1], out program.array2[2, 2], out program.array2[2, 3]);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("звено не может повернуться на этот угол\t");
                            Console.WriteLine("допустимые углы для этого звена -266, 266\t");
                            Console.WriteLine("текущий угол = " + program.array1[3, 5]);
                            break;
                        }
                    case 7:
                        {
                            for (int i = 0; i < 4; i++)
                            {
                                for (int j = 0; j < 4; j++)
                                {
                                    Console.Write("{0}\t", program.array2[i, j]);
                                }
                                Console.WriteLine();
                            }
                            break;
                        }
                    case 8:
                        {
                            for (int i = 0; i < 6; i++)
                            {
                                Console.WriteLine("Звено {0}\t {1}",(i + 1), program.array1[i, 3]);
                            }
                            break;
                        }
                }
            }
        }
    }
}
