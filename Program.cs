double Fibonacci (int n)//было инт, искали для 10. дабл для 40
{
    if(n == 1|| n== 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);//обязательно смотри - должно быть вернуть
}

for (int i = 1; i< 40; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}
