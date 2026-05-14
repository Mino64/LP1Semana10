using System;
using System.Collections.Generic;
using System.IO;

namespace ArcadeLog
{
    public class Program
    {
        // Argumento:
        // args[0]: Caminho para o ficheiro (formato "nome pontuação" por linha)
        private static void Main(string[] args)
        {
            // Lê o Ficheiro e Cria os Scores
            List<Score> scores = new List<Score>();
            // CÓDIGO AQUI
            string fileName = args[0];
            string s;
            using StreamReader sr = new StreamReader(fileName);

            while ((s = sr.ReadLine()) != null)
            {
                string[] temp = s.Split(' ');
                int num = Convert.ToInt32(temp[1]);
                scores.Add(new Score(temp[0], num));

            }
            // Ordena os Scores
            // CÓDIGO AQUI
            scores.Sort();

            // Agrupa por Medalha e Imprime (Gold → Silver → Bronze)
            // Escreve a lista no ficheiro ranking.txt
            // CÓDIGO AQUI
            using StreamWriter sw = new StreamWriter("ranking.txt");
            foreach (Score sc in scores)
            {
                Console.WriteLine(sc);
                sw.WriteLine(sc);
            }

            

            Console.WriteLine("Ranking guardado em 'ranking.txt'.");

            // Ordena por Nome e Escreve em alpha.txt
            // CÓDIGO AQUI

            // Este programa mostra o seguinte no ecrã (exemplo: scores.txt com "Kronos 7400", "Luna 3800", "Rex 520", "Phantom 6100"):
            //
            // Kronos [Gold]: 7400
            // Phantom [Silver]: 6100
            // Luna [Bronze]: 3800
            // Rex [Bronze]: 520
            // Ranking guardado em 'ranking.txt'.
        }
    }
}
