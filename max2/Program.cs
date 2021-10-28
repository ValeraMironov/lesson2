// Максимальное из 3 чисел 

int max(int a,int b,int c)
{
    if(a>b)
    if (a>c) return a; else return b;
    else return c;
}


Console.WriteLine(max(1,2,35));
