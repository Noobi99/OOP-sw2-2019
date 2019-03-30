namespace Lektion3Net
{
    public abstract class ParkingMeter
    {
        protected int multiplier { get; set; }
        
        public virtual int ParkingTime(int coins)
        {
            return coins * multiplier;
        }
        
      
    }

    public class ParkingWeekday : ParkingMeter
    {
        // Default værdi
        private int newMultiplier = 5;
        
        public ParkingWeekday()
        {
            base.multiplier = newMultiplier;
        }
        
    }

    public class ParkingWeekend : ParkingMeter
    {
        // Default værdi
        private int newMultiplier = 10;
        
        public ParkingWeekend()
        {
            base.multiplier = newMultiplier;
        }
    }

}