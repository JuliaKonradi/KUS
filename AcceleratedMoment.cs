using System;

namespace Movements
{
    /// <summary>
    /// Описание  равноускоренного движения
    /// </summary>
    public class AcceleratedMoment : IMoment
    {
        private double _acceleration;
        private double _speed;
        private double _startCoordinate;

      

        /// <summary>
       /// Начальная скорость
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
       /// Ускорение
       /// </summary>
        public double Acceleration { get; set; }

        /// <summary>
        /// Расчет координаты для равноускоренного движения
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public double CalculateCoordinate(double time)
        {
            return StartCoordinate + Speed * time + Acceleration * time * time / 2.0;
        }
    }
}