//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

//Console.WriteLine("Enter a natural number greater than 1:");
//int number = int.Parse(Console.ReadLine());

///Метод вывода натуральных чисел от N до 1:
//void NumberCounter (int number)
//{
  //  if (number < 0) Console.Write($"{number} not a natural number");
    //if (number == 0) return;
    //Console.Write("{0,4}", number);
    //NumberCounter (number - 1);
//}

//NumberCounter(number);

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

//Console.Write("Enter a number M: ");
//int m = Convert.ToInt32(Console.ReadLine());

//Console.Write("Enter a number N: ");
//int n = Convert.ToInt32(Console.ReadLine());

//SumFromMToN(m, n);

// вызов функции "сумма чисел от M до N"
//void SumFromMToN(int m, int n)
//{
  //  Console.Write(SumMN(m - 1, n));
//}

// функция сумма чисел от M до N
//int SumMN(int m, int n)
//{
  //  int res = m;
    //if (m == n)
     //   return 0;
    //else
    //{
      //  m++;
        //res = m + SumMN(m, n);
        //return res;
    //}
//}

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29
 
 //Console.Write("Enter a number M: ");
//int m = Convert.ToInt32(Console.ReadLine());

//Console.Write("Enter a number N: ");
//int n = Convert.ToInt32(Console.ReadLine());

//AkkermanFunction(m,n);


// вызов функции Аккермана
//void AkkermanFunction(int m, int n)
//{
  //  Console.Write(Akkerman(m, n)); 
//}

// функция Аккермана
//int Akkerman(int m, int n)
//{
  //  if (m == 0)
   // {
    //    return n + 1;
    //}
    //else if (n == 0 && m > 0)
    //{
      //  return Akkerman(m - 1, 1);
    //}
    //else
    //{
      //  return (Akkerman(m - 1, Akkerman(m, n - 1)));
    //}
//}