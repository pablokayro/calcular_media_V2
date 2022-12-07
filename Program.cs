using System;
// CALCULO DE MÉDIA APRIMORADO COM ELSE
class Aula13
{
    static void Main(string[]args){

        double n1,n2,n3,n4,media;
        n1=n2=n3=n4=media=0;
        string resultado;

        Console.Write("DIGITE A 1° NOTA(0~10): ");
        n1 = double.Parse(Console.ReadLine());
        Console.Write("DIGITE A 2° NOTA(0~10): ");
        n2 = double.Parse(Console.ReadLine());
        Console.Write("DIGITE A 3° NOTA(0~10): ");
        n3 = double.Parse(Console.ReadLine());
        Console.Write("DIGITE A 4° NOTA(0~10): ");
        n4 = double.Parse(Console.ReadLine());
        
        media = (n1+n2+n3+n4)/4;
        //Média maior ou igual a 7 = APROVADO
        //Média abaixo de 7 ou maior que 4 = RECUPERAÇÃO
        //Média abaixo de 4 = REPROVADO
        //Média acima de 10 ou menor que 0 = VALOR INVALIDO
        if (media>=7 && media<=10 && media>=0){
            resultado="APROVADO!";
        }else if(media>=4 && media<=10 && media>=0){
            resultado="RECUPERAÇÃO!";
        }else if(media<4 && media<=10 && media>=0){
            resultado="REPROVADO!";
        }else{
            resultado="MÉDIA INVÁLIDA!";
        }
        Console.WriteLine($"Media: {media}\nResultado: {resultado}");
    }
}
