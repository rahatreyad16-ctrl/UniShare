using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniShare.Helpers
{
    public static class FareCalculator
    {
        public static decimal EstimateFare(string vehicleType, decimal distanceKm)
        {
            decimal baseFare = 0;
            decimal perKm = 0;

            if (vehicleType == "Bike")
            {
                baseFare = 40;
                perKm = 15;
            }
            else if (vehicleType == "CNG")
            {
                baseFare = 80;
                perKm = 25;
            }
            else if (vehicleType == "Car")
            {
                baseFare = 120;
                perKm = 35;
            }
            else if (vehicleType == "SharePool")
            {
                baseFare = 100;
                perKm = 22;
            }

            return baseFare + (distanceKm * perKm);
        }

        public static int GetMaxSeats(string vehicleType)
        {
            if (vehicleType == "Bike")
                return 2;
            if (vehicleType == "CNG")
                return 4;
            if (vehicleType == "Car")
                return 4;
            if (vehicleType == "SharePool")
                return 4;

            return 4;
        }

        public static decimal CalculateSharedFare(decimal totalFare, int users)
        {
            if (users <= 0)
                return totalFare;

            return totalFare / users;
        }
    }
}