/// <summary>
/// </summary>
public interface IMoment
{
   /// <summary>
   /// Интерфейс различных видов движения
   /// </summary>
   /// <param name="time"></param>
   /// <returns></returns>
    double CalculateCoordinate(double time);
}