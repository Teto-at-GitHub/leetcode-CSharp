public class ParkingSystem
{
    private Dictionary<int, int> SlotAllocation = new();

    public ParkingSystem(int big, int medium, int small)
    {
        SlotAllocation[1] = big;
        SlotAllocation[2] = medium;
        SlotAllocation[3] = small;
    }

    public bool AddCar(int carType)
    {
        var availableSlotsForCarType = SlotAllocation[carType];
        if (availableSlotsForCarType > 0)
        {
            SlotAllocation[carType] -= 1;
            return true;
        }

        return false;
    }
}

/**
 * Your ParkingSystem object will be instantiated and called as such:
 * ParkingSystem obj = new ParkingSystem(big, medium, small);
 * bool param_1 = obj.AddCar(carType);
 */
 
// fastest solution found on leetcode 
// public class ParkingSystem {
//     private int[] ParkingPlaces { get; }
//
//     public ParkingSystem(int big, int medium, int small) {
//         ParkingPlaces = new int[] { 0, big, medium, small };
//     }
//
//     public bool AddCar(int carType) => --ParkingPlaces[carType] >= 0;
// }