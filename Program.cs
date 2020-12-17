using System;

namespace dim_Queda_de_tensão
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Este programa calcula o comprimento do cabo na queda de tensão de 4%!");
            //Entrada de dados:

            double comprimento;
            double potencia;
            double secao;
            double tensao;
            double condut;
            double corrente;

            Console.WriteLine("Digite a área da seção(mm²): ");
            secao = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a tensão (V): ");
            tensao = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantos condutores serão carregados: ");
            condut = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite qual a corrente (A) no circuito: ");
            corrente = double.Parse(Console.ReadLine());
            // Console.WriteLine("Digite o comprimento do cabo: ");
            // comprimento = double.Parse(Console.ReadLine());

            //
            
            potencia = tensao*Math.Pow(corrente,2);
            
            comprimento = (secao*58*0.04*tensao*tensao)/potencia*condut;

            

            // secao = (condut/58)*(1/(0.04*Math.Pow(tensao,2))*potencia*comprimento);

            // Saída
            Console.WriteLine($"o comprimento em metros do cabo será {comprimento}.");
            // Console.WriteLine(potencia);



        }
    }
}
