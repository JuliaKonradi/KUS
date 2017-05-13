using System;

namespace Movements
{
    /// <summary>
    /// Описание колебательного движения
    /// </summary>
    public class FluctationMoment : IMoment
    {
        private double _amplitude;
        private double _frequency;
        private double _startPhase;

      /// <summary>
      /// Амплитуда
      /// </summary>
        public double Amplitude
        {
            get { return _amplitude; }
            set
            {
                if (value < 0)
                    throw new ArgumentException();
                _amplitude = value;
            }
        }

       /// <summary>
       /// Циклическая частота колебаний
       /// </summary>
        public double Frequency
        {
            get { return _frequency; }
            set
            {
                if (value < 0)
                    throw new ArgumentException();
                _frequency = value;
            }
        }

      /// <summary>
      /// Начальная фаза
      /// </summary>
        public double StartPhase
        {
            get { return _startPhase; }
            set
            {
                if (value < 0 || value > 360)
                    throw new ArgumentException();
                _startPhase = value;
            }
        }

     /// <summary>
     /// Расчет координаты для колебательного движения
     /// </summary>
     /// <param name="time"></param>
     /// <returns></returns>
        public double CalculateCoordinate(double time)
        {
            return Amplitude * Math.Sin(Frequency * time + StartPhase);
        }
    }
}