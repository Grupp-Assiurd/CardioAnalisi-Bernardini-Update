using System;

namespace CardioLibrary
{
    public class DataCardio
    {
        public static string BattitiRiposo(int battito)
        {
            if (battito < 60)
                return "Soffri di bradicardia";
            else if (battito >= 60 && battito <= 100)
                return "Hai un battito normale";
            else
                return "soffri di tachicardia";
        }

        public static double CorsaCamminata(double peso, double km, string corsaCamminata)
        {
            double spesaEnergetica = 0;
            if (corsaCamminata.ToLower() == "corsa")
                spesaEnergetica = 0.9 * km * peso;
            else
                spesaEnergetica = 0.50 * km * peso;


            return Math.Round(spesaEnergetica, 2);
        }
    }
}
