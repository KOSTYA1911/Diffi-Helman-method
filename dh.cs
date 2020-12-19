using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace dh{
  class Program{
    static void Main(string[] args){
      //Console.OutputEncoding = Encoding.GetEncoding(886);
    //  Console.InputEncoding = Encoding.GetEncoding(886);

      double a;
      double b;
    //  double c;
    //  c = 8;
    //  double c1;
    //  c1 = 22;
      double d;
      double d1;
      double e;
      double e1;


      Console.Write("Введите общий ключ для Алисы и Боба:");
      a = Convert.ToDouble(Console.ReadLine());

      Console.Write("Введите еще один общий ключ для Алисы и Боба:");
      b = Convert.ToDouble(Console.ReadLine());

    //  Console.Write("Введите секретный ключ Алисы:");
  //    с = Convert.ToDouble(Console.ReadLine());
  //    Console.Write("Введите секретный ключ Боба:");
//с1 = Convert.ToDouble(Console.ReadLine());

      d =  Math.Pow(b,8) % a;
      d1 = Math.Pow(b,22) % a;

      Console.WriteLine("Результат Алисы после проведения операций: {0}", d);
      Console.WriteLine("Результат Боба после проведения операций: {0}", d1);

      e = Math.Pow(d1,8) % a;
      e1 = Math.Pow(d,22) % a;

      Console.WriteLine("Результат Алисы после обмена ключами: {0}", e);
      Console.WriteLine("Результат Боба после обмена ключами: {0}", e1);
      Console.ReadLine();
    }
  }
}
