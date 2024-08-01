using System;

namespace CSharpHelloC
{
  class HelloC
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hola, C#");

      string myString = "Esto es una cadena de texto";
      myString = "Aquí cambio el valor de la cadena de texto";
      Console.WriteLine(myString);

      // Tipo de dato entero "int"
      int myInt = 7;
      myInt = myInt + 4;
      Console.WriteLine(myInt);
      Console.WriteLine(myInt - 1);
      Console.WriteLine(myInt);

      // Tipo de dato decimal "float"
      double myDouble = 6.5;
      Console.WriteLine(myDouble);

      float myFloat = 6.5f;
      Console.WriteLine(myFloat);

      // Tipo de dato boolean "bool"
      bool myBool = true;
      myBool = false;
      Console.WriteLine(myBool);

      // Interpolar valores
      Console.WriteLine($"El valor de mi entero es {myInt} y el de mi bool es {myBool}");

      // Variable const
      const string MyConst = "Mi constante";
      Console.WriteLine(MyConst);

      // Estructuras
      var myArray = new string[] { "Emi", "Ramirez", "emilioDev" };
      Console.WriteLine(myArray[0]);

      myArray[2] = "36";
      Console.WriteLine(myArray[2]);

      // Estructura Diccionario
      var myDictionary = new Dictionary<string, int>
      {
        {"emilioDev",35},
        {"Victoria",30},
        {"algo",50}
      };
      Console.WriteLine(myDictionary["emilioDev"]);

      // Estructura Set
      var mySet = new HashSet<string> { "Emi", "Ramirez", "emilioDev", "emilioDev" };
      Console.WriteLine(mySet);

      // Estructura Tuple
      var myTuple = ("Emi", "Ramirez", "emilioDev");
      Console.WriteLine(myTuple);
    }
  }
}


