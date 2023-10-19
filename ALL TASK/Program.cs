#region 1.Verilmiş n və m (n<m) ədədləri arasında neçə tək ədəd olduğunu tapın.

//int n = int.Parse(Console.ReadLine());
//int m = int.Parse(Console.ReadLine());
//int count = 0;
//for (int i = n; i <= m; i++)
//{
//    if (i % 2 == 1)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);

#endregion

#region 2. Verilmiş n tam ədədinin sadə və ya mürəkkəb ədəd olduğunu tapın. (2 code)

//int n = int.Parse(Console.ReadLine());
//int count = 0;

//if (n==0 || n==1)
//{
//    Console.WriteLine("diger eded daxil edin..");
//}
//else if (n > 1)
//{
//for (int i = 1; i <= n; i++)
//    {
//        if (n%i==0)
//        count++;
//    }
//if (count >2)
//{
//    Console.WriteLine("murekkeb");
//}
//else
//{
//    Console.WriteLine("sade");
//}
//}

//int n = int.Parse(Console.ReadLine());
//int count = 0;
//for(int i=1;i<=n;i++)
//{
//    if (n % i == 0)
//    {
//        count++;
//        if (count > 2)
//        {
//            break;
//        }
//    }     
//}
//if (count>2)
//{
//    Console.WriteLine("murekkeb...");
//}
//else
//{
//    Console.WriteLine("sade...");
//}

#endregion

#region 3.Verilmiş müsbət tam n ədədinin 2-nin qüvvəti olub-olmamasını tapın.

//int n=int.Parse(Console.ReadLine());
//while (n % 2 == 0)
//{
//    n /= 2;
//}
//if (n == 1)
//{
//    Console.WriteLine("2-nin quvvetidir");
//}
//else
//{
//    Console.WriteLine("deyil..");
//}

#endregion

#region 4. Verilmiş n tam ədədinin neçə mərtəbəli olduğunu tapın. Məs: 23452, output: 5

//int n = int.Parse(Console.ReadLine());
//int count = 0;

//while (n != 0)
//{
//    n /= 10;
//    count++;
//}
//Console.WriteLine(count);

#endregion