using System;

namespace homework1st_week
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[,] originalArray = new int[10, 10];
            int[,] snakeArray = new int[10, 10];

            MyFunction.fillingArray(originalArray);
            Console.WriteLine("\n original array \n");
            MyFunction.ShowArray(originalArray);
            MyFunction.SnakedFillingLeftRight(MyFunction.TransformToLine(originalArray), snakeArray);
            Console.WriteLine("\n snaked array left -> right \n");
            MyFunction.ShowArray(snakeArray);
            MyFunction.SnakedFillingRightLeft(MyFunction.TransformToLine(originalArray), snakeArray);
            Console.WriteLine("\n snaked array right -> left \n");
            MyFunction.ShowArray(snakeArray);
            MyFunction.SnakedFillingTopBottom(MyFunction.TransformToLine(originalArray), snakeArray);
            Console.WriteLine("\n snaked array top -> bottom \n");
            MyFunction.ShowArray(snakeArray);
            MyFunction.SnakedFillingBottomTop(MyFunction.TransformToLine(originalArray), snakeArray);
            Console.WriteLine("\n snaked array bottom -> top \n");
            MyFunction.ShowArray(snakeArray);
        }
    }

    class MyFunction
    {
        //~~~~~~~~~~~~~~~~common function~~~~~~~~~~~~~~~
        //filling origonal array
        public static void fillingArray(int[,] inpArr)
        {
            for (int i = 0, k = 1; i<inpArr.GetLength(0); i++)
            {
                for (int y = 0; y<inpArr.GetLength(1); y++, k++)
                {
                    inpArr[i, y] = k;
                }
            }
        }


        //Show array
        public static void ShowArray(int[,] arrForOutp)
        {
            for (int i = 0; i < arrForOutp.GetLength(0); i++)
            {
                for (int j = 0; j < arrForOutp.GetLength(1); j++)
                {
                    Console.Write("\t{0}", arrForOutp[i, j]);
                }
                Console.WriteLine("\n");
            }
        }


        // transform to one-dimensional array
        public static int[] TransformToLine(int[,] a)
        {
            int transformIterator = new int();
            int[] lineArray = new int[a.Length];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int y = 0; y < a.GetLength(1); y++)
                {
                    lineArray[transformIterator] = a[i, y];
                    transformIterator++;
                }
            }
            return lineArray;
        }



        //~~~~~~~~~~~~~~~~filling function~~~~~~~~~~~~~~~
        //left>right filling
        public static void SnakedFillingLeftRight(int[] inpArr, int[,] outArr)
        {
            int lineIterator = new int();

            for (int i = 0; i < outArr.GetLength(0); i++)
            {
                if (i % 2 == 0)
                {
                    for (int y = 0; y < outArr.GetLength(1); y++)
                    {
                        outArr[i, y] = inpArr[lineIterator];
                        lineIterator++;
                    }
                }
                else
                {
                    for (int y = outArr.GetLength(1) - 1; y >= 0; y--)
                    {
                        outArr[i, y] = inpArr[lineIterator];
                        lineIterator++;
                    }
                }
            }
        }


        //right>left filling
        public static void SnakedFillingRightLeft(int[] inpArr, int[,] outArr)
        {
            int lineIterator = new int();

            for (int i = 0; i < outArr.GetLength(0); i++)
            {
                if (i % 2 == 0)
                {
                    for (int y = outArr.GetLength(1)-1; y >= 0 ; y--)
                    {
                        outArr[i, y] = inpArr[lineIterator];
                        lineIterator++;
                    }
                }
                else
                {
                    for (int y = 0; y < outArr.GetLength(1); y++)
                    {
                        outArr[i, y] = inpArr[lineIterator];
                        lineIterator++;
                    }
                }
            }
        }


        //top>bottom filling
        public static void SnakedFillingTopBottom(int[] inpArr, int[,] outArr)
        {
            int lineIterator = new int();

            for (int y = 0; y < outArr.GetLength(1); y++)
            {
                if (y % 2 == 0)
                {
                    for (int i = 0; i < outArr.GetLength(0); i++)
                    {
                        outArr[i, y] = inpArr[lineIterator];
                        lineIterator++;
                    }
                }
                else
                {
                    for (int i = outArr.GetLength(0) - 1; i >= 0; i--)
                    {
                        outArr[i, y] = inpArr[lineIterator];
                        lineIterator++;
                    }
                }
            }
        }


        //bottom>top filling
        public static void SnakedFillingBottomTop(int[] inpArr, int[,] outArr)
        {
            int lineIterator = new int();

            for (int y = outArr.GetLength(1)-1; y >= 0; y--)
            {
                if (y % 2 == 0)
                {
                    for (int i = outArr.GetLength(0) - 1; i >= 0; i--)
                    {
                        outArr[i, y] = inpArr[lineIterator];
                        lineIterator++;
                    }
                }
                else
                {
                    for (int i = 0; i < outArr.GetLength(0); i++)
                    {
                        outArr[i, y] = inpArr[lineIterator];
                        lineIterator++;
                    }
                }
            }
        }

    }
}
