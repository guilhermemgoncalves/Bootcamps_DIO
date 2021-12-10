# Programando em C#

## 1 - Xenlongão *

Todas  as esferas cujo o número de divisores da quantidade de estrela da esfera sejam par

Como saber disso?

para saber se um numero tem um divisor tenho que ir dividindo esse numero até que ele seja igual a 0 ou 1 (ainda decidir) e quando isso acontecer, todos os números que o resto for zero são divisores desse numero.

```
int quantidadeDeEsferas = 7;
int quantidadeDeDivisores= 0;
int i;

for (i=quantidadeDeEsferas; i==0; i-- )
{
  if((quantidadeDeEsferas%i)!=0)
  {
    quantidadeDeDivisores++;
  }
}
```

```
using System;

using System.Collections.Generic;

using System.Text;



namespace Dio

{

  class Xenlongao

  {

    static void Main(string[] args)

    {

    var testes = int.Parse(Console.ReadLine());



    for (int i = 0; i < testes; i++)

    {

    var esferas = int.Parse(Console.ReadLine());

    Console.WriteLine(esferas - Math.Floor(Math.Sqrt(esferas)));

    }

  }

 }

}
```



## 2 **Quadrado de Pares**



    using System; 
    
    class DIO {
    static void Main(string[] args) { 
    
      double n = int.Parse(Console.ReadLine());
      double i;
            for( i=2;i<=n;i++         )
            {
              if((i%2)==0)
              {
                double b = Math.Pow(i, 2)   ;          //escreva o seu código nos espaços em branco
                Console.WriteLine($"{i}^2 = {b}");
              }
            }
    
    }
    }





## 3 **Sequência S**



    using System; 
    
    class DIO {
    
        static void Main(string[] args) { 
    
          float a, c=1, S= 0;
                for ( a=1; a<=100; a++     )
                {
                    c =  1/a         ;  //coloque a sua lógica nos espaços em branco
                    S +=    c    ;
                     
                }
                var x = Math.Round(S,2);
                Console.WriteLine(x);
        }
    }



## 4 **Sequencia IJ 2** 



    using System; 
    
    class DIO {
    static void Main(string[] args) { 
       
    int i,j;
    
    for (i=0; i<=9; i++)
    {
      if((i%2)!=0)
      {
        for(j=7; j>=5;j--)
        Console.WriteLine($"I={i} J={j}");
      }
    }
    }
    }



## 5 **Vai Ter Copa?**




    using System; 


​    
​    class DIO {
​    static void Main(string[] args) { 
​    
     string str;
            while((str=Console.ReadLine())!= null)
            {
                
                    int x = int.Parse(str);
                    if ( x<=0        )
                    {
                    Console.WriteLine("vai ter copa!"   ); 
                    }
                    else
                    {
                        Console.WriteLine("vai ter duas!"   );
                    }
                
            }
    
    }

}

## 6 - Sucessor Par




​    
​    using System; 
​    
    class DIO{
    
     {static void Main(string[] args) { 
    
    int x = int.Parse(Console.ReadLine());
            
        if(x%2 == 1) 
        Console.WriteLine(x+1);//escreva aqui o seu código
        else
        Console.WriteLine(x+2);
    
    }
    }


​    



