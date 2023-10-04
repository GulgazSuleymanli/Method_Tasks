namespace Method_Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //EvenNumSum(10); 
            #endregion


            #region Task 2 
            //if (AverScore(90, 30, 50) > 60)
            //{
            //    Console.WriteLine("Mezun oldunuz");
            //}
            //else
            //{
            //    Console.WriteLine("Mezun ola bilmediniz");
            //} 
            #endregion


            #region Task 3
            //int a = Area(3,5);
            //if(a==-1)
            //{
            //    Console.WriteLine("Verilen olculer fiqura uygun deyil");
            //}
            //else
            //{
            //    Console.WriteLine("Sahe=" + a);
            //} 
            #endregion
        }


        #region Task 1_Method
        //static void EvenNumSum(int num)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < num; i++)
        //    {
        //        if (i %2==0)
        //        {
        //            sum+=i;
        //        }
        //    }
        //    Console.WriteLine(sum);
        //} 
        #endregion


        #region Task 2_Method
        //static int AverScore(params int[] score)
        //{
        //    int sum = 0;
        //    int count = 0;
        //    for (int i = 0; i < score.Length; i++)
        //    {
        //        sum += score[i];
        //        count++;
        //    }
        //    return sum / count;
        //} 
        #endregion


        #region Task 3_Method
        //static int Area(int r)
        //{
        //    int p = 3;
        //    int s = p * r * r;
        //    return s;
        //}
        //static int Area(int a, int b)
        //{
        //    if(a!=b)
        //    {
        //        int s = a * b;
        //        return s;
        //    }
        //    return -1;
        //}
        //static int Area(int a, int b, int c)
        //{
        //    if (a < b && a >= c)
        //    {
        //        int s = 2 * (a * b + a * c + b * c);
        //        return s;
        //    }
        //    else
        //    {
        //        return -1;
        //    }
        //}
        //static int Area(int a, int b, int c, int r)
        //{
        //    if (a <= b + c && b <= a + c && c <= a + b && r < a && r < b && r < c)
        //    {
        //        int p = (a + b + c) / 2;
        //        int s = p * r;
        //        return s;
        //    }
        //    else
        //    { 
        //        return -1; 
        //    }
        //} 
        #endregion
    }
}