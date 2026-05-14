using System;

namespace ArcadeLog
{
    public class Score : IComparable<Score>
    {
        // Variável de Instância Privada: points (int)
        // done
        private int points;

        // Propriedade Auto-Implementada Só de Leitura: Name (string)
        // done
        public string Name { get; }
        // Propriedade: Points (int), sempre entre 0 e 9999
        // done
        public int Points
        {
            get
            {
                if (points >= 9999) return 9999;
                if (points <= 0) return 0;
                return points;
            }
            set
            {
                points = value;
                if(points < 0) points = 0;
            }
        }
        // Propriedade Só de Leitura: Medal (string)
        // done

        public string Medal
        {
            get
            {
                switch (points)
                {
                    case >= 7000:
                        return "Gold";

                    case >= 4000:
                        return "Silver";

                    default:
                        return "Bronze";
                }
            }
        }

        // Construtor: aceita nome e pontuação
        // done

        public Score(string name, int score)
        {
            Name = name;
            Points = score;
        }

        public int CompareTo(Score other)
        {
            // done?
            if(other is null) return 1;
            return other.points - this.points; // substitua o return
        }

        public override string ToString()
        {
            // done
            return $"{Name} [{Medal}]: {Points}"; // substitua o return
        }
    }
}
