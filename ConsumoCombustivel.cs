using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TestePratico
{
    public class ConsumoCombustivel
    {
        public List<ConsumoCombustivel> carros = new List<ConsumoCombustivel>();
        public int numero_serie = 0;
        public int capacidade { get; set; }
        public string portador { get; set; }

        public int litros = 0;

        public static int id = 1;
        public ConsumoCombustivel(int capacidade, string portador)
        {
            this.numero_serie = id++;
            this.capacidade = capacidade;
            this.portador = portador;
        }

        public void Excluir(int numero_serie)
        {
            ConsumoCombustivel? carro = carros.Find(c => c.numero_serie == numero_serie);
            carros.Remove(carro);
            Console.WriteLine("Carro excluído com sucesso: Numero de Serie {0} - Portador {1}", carro.numero_serie, carro.portador);

        }

        public void Alterar(int numero_serie, int capacidade, string portador)
        {
            ConsumoCombustivel? carro = carros.Find(c => c.numero_serie == numero_serie);

            carro.capacidade = capacidade;
            carro.portador = portador;

            Console.WriteLine("Carro alterado com sucesso: Numero de Serie {0} - Portador {1} - Capacidade {2}", carro.numero_serie, carro.portador, carro.capacidade);

        }

        public void MostrarCarros()
        {
            Console.WriteLine("Lista de carros:");

            foreach (ConsumoCombustivel carro in carros)
            {
                Console.WriteLine("Numero de Serie {0} - Portador {1} - Capacidade {2} - Litros {3}", carro.numero_serie, carro.portador, carro.capacidade, carro.litros);
            }
        }

        public void Incluir(ConsumoCombustivel carro)
        {
            carros.Add(carro);
            Console.WriteLine("Carro adicionado com sucesso!");
        }


        public void Abastecer()
        {
            Console.WriteLine("Insira a quantidade de litros a serem abastecidos: ");
            int numeroDeLitros = int.Parse(Console.ReadLine());

            if (numeroDeLitros > 0)
            {
                if (this.litros + numeroDeLitros > this.capacidade)
                {
                    Console.WriteLine("Não foi possivel abastecer, capacidade excedida. A capacidade máxima é de {0} litros. ", this.capacidade);
                }
                else
                {
                    this.litros += numeroDeLitros;
                    Console.WriteLine("{0} Litros foram adicionados ao tanque.", numeroDeLitros);
                    Console.Write("Número de litros disponiveis: {0} \n", this.litros);
                }
            }
            else
            {
                Console.WriteLine("A quantidade de combustível deve ser maior que zero.");
            }

        }

        public void Rodar()
        {
            Console.WriteLine("Insira a quantidade de litros a serem utilizados: ");
            int litrosUtilizar = int.Parse(Console.ReadLine());

            if (this.litros > 0 && litrosUtilizar > 0)
            {
                this.litros -= litrosUtilizar;
                Contar();
            }
            else
            {
                Contar();
            }

        }
        public void Contar()
        {
            Console.WriteLine("O tanque do carro de {0} possui {1} litros de combustível.", this.portador, this.litros);
        }

        public void Ler()
        {
            Console.WriteLine("**************************");
            Console.WriteLine("Serie: " + numero_serie + "\n");
            Console.WriteLine("Portador: " + portador + "\n");
            Console.WriteLine("Capacidade: " + capacidade + "\n");
            Console.WriteLine("Litros: " + litros + "\n");
            Console.WriteLine("**************************");
        }
    }
}
