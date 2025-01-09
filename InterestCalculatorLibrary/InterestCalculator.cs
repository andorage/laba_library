using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculatorLibrary
{
    public class InterestCalculator
    {
        // Метод для расчета простых процентов
        public double SimpleInterest(double principal, double rate, int periods)
        {
            return principal * (1 + rate * periods);
        }

        // Метод для расчета сложных процентов


        //ДОПУСТИМ ВОТ ЗДЕСЬ Я ЧТО-ТО ИЗМЕНИЛ
        public double CompoundInterest(double principal, double rate, int periods)
        {
            return principal * Math.Pow(1 + rate, periods);
        }

        // Метод для расчета номинальной процентной ставки
        public double NominalInterest(double principal, double rate, int periods, int compoundsPerYear)
        {
            return principal * Math.Pow(1 + rate / compoundsPerYear, compoundsPerYear * periods);
        }


        //ЗДЕСЬ Я ТОЖЕ ЧТО-ТО ПОМЕНЯЛ

        // Метод для расчета непрерывных процентов
        public double ContinuouslyCompoundedInterest(double principal, double growthRate, int periods)
        {
            return principal * Math.Exp(growthRate * periods);
        }

        // Метод для расчета реальной процентной ставки
        public double RealInterestRate(double nominalRate, double inflationRate)
        {
            return (nominalRate - inflationRate) / (1 + inflationRate);
        }
    }
}
