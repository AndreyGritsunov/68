Console.WriteLine("Введите число N: ");
int m = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Введите число M: ");
int n = Convert.ToInt16(Console.ReadLine());

int sum = RecursionTotal(n, m);

Console.Write(sum);



static int RecursionTotal(int n, int m)
{
  if (n == 0){

    return m + 1;

  }
  else{
    if ((n != 0) && (m == 0)){

      return RecursionTotal(n - 1, 1);
    }
    else{

      return RecursionTotal(n - 1, RecursionTotal(n, m - 1));
    }
  }
}

