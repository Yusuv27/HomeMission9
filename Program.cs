void Number1()
{
    Console.WriteLine("Введите число N");
    int N=Convert.ToInt32(Console.ReadLine());
    int i=N;
    otvet();
    void otvet()
    {
            if(i!=0)
            {
            Console.Write(i+" ");
            i=i-1;
            otvet();
            }
    }
}
void Number2()
{
    Console.WriteLine("Введите число M");
    int M=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N");
    int N=Convert.ToInt32(Console.ReadLine());
    int sum=0;
    for(int i=M;i!=N+1;i++)
    {
        sum=sum+i;
    }
    Console.WriteLine(sum);
}
void Number3()
{
    int num8=4;
    int [,] Akkerman= new int [4,11];
    for(int i=0;i<Akkerman.GetLength(0);i++)
    {
        for(int j=1;j<Akkerman.GetLength(1);j++)
        {   
            if(i==0)
            {
                Akkerman[0,0]=1;
                Akkerman[i,j]=Akkerman[i,j-1]+1;
            }
            else if(i==1)
            {
                Akkerman[1,0]=2;
                Akkerman[i,j]=Akkerman[i,j-1]+1;
            }
            else if(i==2)
            {
                Akkerman[2,0]=3;
                Akkerman[i,j]=Akkerman[i,j-1]+2;
            }
            else if(i==3)
            {
                num8=num8*2;
                Akkerman[3,0]=5;
                Akkerman[i,j]=Akkerman[i,j-1]+(num8);
            }
        }
    }
    Console.WriteLine("Введите число m: ");
    int m=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число n: ");
    int n=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(Akkerman[m,n]);
}
Console.WriteLine("Задание 64");
Number1();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Задание 66");
Number2();
Console.WriteLine();
Console.WriteLine("Задание 68");
Number3();