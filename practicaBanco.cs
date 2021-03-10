using System;
using System.Collections;

namespace MainClass {

  class Program{
      public static void Main (string[] args) {
        
        int op=0;
        float monto;
        Cliente cliente1 = new Cliente("Manuel","Gomez",12500);
        Cliente cliente2 = new Cliente("Pedro","Antonio",5000);
        Cliente cliente3 = new Cliente("Marta","Diaz",27300);
        Cliente clienteActual=new Cliente();

        Console.WriteLine("Bienvenido!");


        Console.WriteLine("Eliga una opcion:\n1)Acceder a Cliente 1\n2)Acceder a Cliente 2\n3)Acceder a Cliente 3");

          
        op=Int32.Parse(Console.ReadLine());

        if (op==1){clienteActual=cliente1;} 
        else if(op==2){clienteActual=cliente2;}  
        else if(op==3){clienteActual=cliente3;}   
     
      
        op=0;
        Console.WriteLine("Nombre: "+clienteActual.Nombre+ "\nApellido: "+clienteActual.Apellido);
        while (op!=3){ 

          Console.WriteLine("Balance actual: "+clienteActual.Deposito+"\nQue desea realizar?\n1)Deposito\n2)Retiro\n3)Salir");
          op=Int32.Parse(Console.ReadLine());
          
          if (op==1){
            Console.Write("Introduzca el monto a depositar: ");
            monto=Int32.Parse(Console.ReadLine());
            clienteActual.RealizarDeposito(monto);
          }
          else if (op==2){
            Console.Write("Introduzca el monto a retirar: ");
            monto=Int32.Parse(Console.ReadLine());
            clienteActual.RealizarRetiro(monto);
          }
          else if (op==3){break;}

      }

      Console.WriteLine("Balance Total: "+(cliente1.Deposito+cliente2.Deposito+cliente3.Deposito));




      
      }

      }

  class Cliente{

      public string Nombre;
      public string Apellido;
      public float Deposito;
      public float Retiro;

    public Cliente(){}

    public Cliente(string nombre,string apellido,float deposito){
      Nombre = nombre;
      Apellido = apellido;
      Deposito = deposito;
      Retiro=0;
    }

    public void RealizarDeposito(float deposito){
      Deposito += deposito;
    }

    public void RealizarRetiro(float retiro){
      Deposito -= retiro;
    }



    }




  
}