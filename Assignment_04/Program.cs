namespace Assignment_04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q17
            //int x1, x2, x3, y1, y2, y3;
            //int slope1, slope2, slope3;

            //Console.WriteLine("enter point1");
            //x1 = int.Parse(Console.ReadLine());
            //y1=int.Parse(Console.ReadLine());
            //Console.WriteLine("enter point2");
            //x2 = int.Parse(Console.ReadLine());
            //y2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter point3");
            //x3 = int.Parse(Console.ReadLine());
            //y3= int.Parse(Console.ReadLine());

            //slope1 = y2 - y1 / x2 - x1;
            //slope2 = y3 - y2 / x3 - x2;
            //slope3 = y3 - y1 / x3 - x1;

            //if (slope1 == slope2 && slope1 == slope3)
            //{
            //    Console.WriteLine("these points lie on a single straight line");
            //}
            //else
            //    Console.WriteLine("these points  don not lie on a single straight line");

            #endregion


            #region Q18
            //Console.WriteLine("enter hour work");
            //int hours=int.Parse(Console.ReadLine());
            //if (hours <= 3)
            //{
            //    Console.WriteLine("highly efficient");
            //}
            //else if (hours >= 3 && hours <= 4)
            //{
            //    Console.WriteLine("increase  your speed.");
            //}
            //else if (hours >= 4 && hours <= 5)
            //{
            //    Console.WriteLine("training to enhance their speed.");
            //}

            //else if (hours > 5)
            //{
            //    Console.WriteLine("you have to leave the company ");
            //}
            #endregion


            #region Q19
            //int number;
            //bool flag;
            //do
            //{
            //    Console.WriteLine("enter size of matrix");
            //    flag = int.TryParse(Console.ReadLine(), out number);
            //} while (!flag);

            //for(int i = 0; i < number; i++)
            //{
            //    for(int j = 0; j < number; j++)
            //    {
            //        if(i==j)
            //            Console.Write($" {1} ");
            //        else
            //            Console.Write($" {0} ");
            //    }
            //    Console.Write("\n");

            //}



            #endregion

            #region Q20

            //int size;
            //bool flag;

            //do
            //{
            //    Console.WriteLine("enter size");
            //    flag = int.TryParse(Console.ReadLine(), out size);
            //} while (!flag);

            //int[] array = new int[size];

            //for(int i = 0; i < size; i++)
            //{
            //    do
            //    {
            //        Console.WriteLine($"enter number {i + 1}");
            //        flag = int.TryParse(Console.ReadLine(), out array[i]);
            //    } while (!flag);

            //}

            //int sum=0;
            //for (int i = 0; i < size; i++)
            //    sum += array[i];

            //Console.WriteLine($"sum={sum}");
            #endregion


            #region Q21
            //int size;
            //bool flag;
            //do
            //{
            //    Console.WriteLine("enter size");
            //    flag = int.TryParse(Console.ReadLine(), out size);
            //} while (!flag);

            //int[] array01 = new int[size];
            //Console.WriteLine("enter first array");
            //for (int i = 0; i < size; i++)
            //{
            //    do
            //    {

            //        Console.WriteLine($"enter number{i + 1}");
            //        flag = int.TryParse(Console.ReadLine(), out array01[i]);
            //    } while (!flag);
            //}
            //int[] array02 = new int[size];
            //Console.WriteLine("enter second array");
            //for (int i = 0; i < size; i++)
            //{
            //    do
            //    {

            //        Console.WriteLine($"enter number{i + 1}");
            //        flag = int.TryParse(Console.ReadLine(), out array02[i]);
            //    } while (!flag);
            //}
            //int size2 = 2 * size;
            //int[] array03 = new int[size2];
            //int x;
            //for (x = 0; x < size; x++)
            //    array03[x] = array01[x];
            //for(int i = 0; i < size; i++)
            //{
            //    array03[x] = array02[i];
            //    x++;
            //}

            //int t;
            //for(int i = 0; i < size2; i++)
            //{
            //    for(int j = i + 1; j < size2; j++)
            //    {
            //        if (array03[i] > array03[j])
            //        {
            //            t = array03[i];
            //            array03[i] = array03[j];
            //            array03[j] = t;
            //        }

            //    }
            //}
            //Console.WriteLine("array after merge and sort");

            //for(int i = 0; i < size2; i++)
            //{
            //    Console.WriteLine($" {array03[i] } ,");
            //}
            #endregion


            #region Q22
            //int size;
            //bool flag;
            //do
            //{
            //    Console.WriteLine("enter size");
            //    flag = int.TryParse(Console.ReadLine(), out size);
            //} while (!flag);

            //int[] array = new int[size];
            //int[] freq = new int[size];
            //for(int k = 0; k < size; k++)
            //{
            //    do
            //    {
            //        Console.WriteLine($"enter number {k + 1}");
            //        flag = int.TryParse(Console.ReadLine(), out array[k]);
            //        freq[k] =-1;
            //    } while (!flag);      
            //}
            //int i, j, counter;
            //for(  i = 0; i < size; i++)
            //{
            //    counter = 1;
            //    for(  j = i + 1; j < size; j++)
            //    {
            //        if (array[i] == array[j])
            //        {
            //            counter++;
            //            freq[j] = 0;
            //        }
            //        if (freq[i]!=0)
            //            freq[i]=counter;
            //    }
            //}
            //Console.WriteLine(" frequency =");
            //for(int x = 0; x < size; x++)
            //{
            //    if (freq[x]!=0)
            //    {
            //        Console.WriteLine($" {array[x]} occurs: {freq[x]}");
            //    }
            //}
            //1 2 3 4 5 3 2 1 5 3
            #endregion


            #region Q23
            //int size;
            //bool flag;
            //do
            //{
            //    Console.WriteLine("enter size");
            //    flag = int.TryParse(Console.ReadLine(), out size);
            //} while (!flag);

            //int[] array = new int[size];
            //int min= 99999999, max=0;
            //for (int i = 0; i < size; i++)
            //{
            //    do
            //    {
            //        Console.WriteLine($"enter number {i + 1}");
            //        flag = int.TryParse(Console.ReadLine(), out array[i]);

            //    } while (!flag);
            //    if(array[i] < min)
            //    {
            //        min = array[i];
            //    }
            //    if (array[i] > max) { 
            //    max=array[i];
            //    }
            //}


            //    Console.WriteLine($"the max is: {max}");
            //Console.WriteLine($"the min is: {min}");

            #endregion


            #region Q24
            //int size;
            //bool flag;
            //do
            //{
            //    Console.WriteLine("enter size");
            //    flag = int.TryParse(Console.ReadLine(), out size);
            //} while (!flag);
            //int max = 0;
            //int[] array = new int[size];
            //for(int i = 0; i < size; i++)
            //{
            //    do
            //    {
            //        Console.WriteLine($"enter numer {i + 1}");
            //        flag = int.TryParse(Console.ReadLine(), out array[i]);
            //    } while (!flag);
            //    if(array[i] > max)
            //    {
            //        max = array[i];
            //    }

            //}
            //int second = 0;

            //for (int i = 0; i < size; i++) {
            //    if (array[i] > second && array[i] < max)

            //        second=array[i];

            //}

            //Console.WriteLine($"second : {second}");


            #endregion



            #region Q25
            //int size;
            //bool flag;
            //do
            //{
            //    Console.WriteLine("enter size");
            //    flag = int.TryParse(Console.ReadLine(), out size);
            //} while (!flag);
            //int max = 0;
            //int[] array = new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    do
            //    {
            //        Console.WriteLine($"enter numer {i + 1}");
            //        flag = int.TryParse(Console.ReadLine(), out array[i]);
            //    } while (!flag);

            //}
            //int space = 0;
            //for (int i = 0; i < size; i++)
            //    {
            //        for(int j = i + 1; j < size; j++)
            //        {
            //        if (array[i] == array[j])
            //        {
            //            if (space < j - i - 1)
            //                space = j - i - 1;
            //        }
            //        }
            //    }
            //    Console.WriteLine($"space between: {space} ");

            #endregion


            #region Q26
            //Console.WriteLine("enter your word");
            //string word = Console.ReadLine();
            //string[] str = word.Split(" ");
            //string result = "";

            //for(int i = str.Length-1; i>=0; i--)

            //    result += str[i] + " ";

            //Console.WriteLine( result);
            #endregion


            #region Q27
            //int[,] arr1 = new int[2,2];
            //int[,] arrr2 = new int[2, 2];
            //for (int i = 0; i < 2; i++) {
            //    for (int j = 0; j < 2; j++) {
            //        Console.WriteLine("enter value  ");
            //        arr1[i,j] = int.Parse(Console.ReadLine());

            //    }
            //}

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {

            //        arrr2[i, j] = arr1[i, j]; 

            //    }
            //}
            //Console.WriteLine("the array: ");
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Console.WriteLine($"{arrr2[i,j]}");


            //    }
            //}

            #endregion



            #region Q28
            //int size;
            //bool flag;
            //do
            //{
            //    Console.WriteLine("enter size");
            //    flag = int.TryParse(Console.ReadLine(), out size);
            //} while (!flag);
            //int[] array=new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    do
            //    {
            //        Console.WriteLine($"enter number {i + 1}");
            //        flag = int.TryParse(Console.ReadLine(), out array[i]);
            //    } while (!flag);

            
            //}

            //for(int i = size-1; i >= 0; i--)
            //{
            //    Console.WriteLine($" {array[i]}");
            //}

            #endregion
        }
    }
}
