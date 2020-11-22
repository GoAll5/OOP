using System;
using System.Collections.Generic;
using System.Text;

namespace laba3
{   
    public class Race<T>
        where T : Transport
    {
        public double Distance;
        public List<T> Players;

        public Race(double distance, List<T> players)
        {
            Distance = distance;
            Players = players;
        }

        public T FirstPlayer()
        {
            double min = Double.MaxValue;
            T firstPlayer = null;
            foreach(var player in Players)
            {
                double result = player.Result(Distance);
                if (result < min)
                {
                    min = result;
                    firstPlayer = player;
                }
            }
            return firstPlayer;
            
        }

        
    }
    public class AllTsRace : Race<Transport>
    {
        public AllTsRace(double distance, List<Transport> transports)
            : base(distance, transports) { }
    }
    public class LandTsRace : Race<LandTS>
    {
        public LandTsRace(double distance, List<LandTS> transports)
            : base(distance, transports) { }
    }
    public class AirTsRace : Race<AirTS>
    {
        public AirTsRace(double distance, List<AirTS> transports)
            : base(distance, transports) { }
    }
}
