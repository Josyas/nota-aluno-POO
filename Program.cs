﻿using System;
using System.Globalization;

namespace nota_aluno_POO_again {
    class Program {
        static void Main(string[] args) {

            Aluno aluno = new Aluno();

                     

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    
            if (aluno.Aprovado()) {
                Console.WriteLine("APROVADO!!!");
            }
            else {
                Console.WriteLine("REPROVADO!!!");
                Console.WriteLine("FALTAM "
                    + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)
                    + " PONTOS" );
            }

            
        }
    }
}
