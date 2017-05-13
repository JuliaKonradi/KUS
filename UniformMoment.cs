using System;

namespace Movements
{
   /// <summary>
   /// Описание равномерного движения
   /// </summary>
    public class UniformMoment: IMoment
    {
        private double _speed;
        private double _startCoordinate;

       /// <summary>
       /// Скорость
       /// </summary>
        public double Speed
        {
            get { return _speed; }
            set
            {
                if (value < 0)
                    throw new ArgumentException();
                _speed = value;
            }
        }

       /// <summary>
       /// Начальная координата
       /// </summary>
        public double StartCoordinate
        {
            get { return _startCoordinate; }
            set
            {
                if (value < 0)
                    throw new ArgumentException();
                _startCoordinate = value;
            }
        }

       /// <summary>
       /// Рассчет координаты для равномерного движения
       /// </summary>
       /// <param name="time"></param>
       /// <returns></returns>
        public double CalculateCoordinate(double time)
        {
            return StartCoordinate + Speed * time;
        }
    }
}