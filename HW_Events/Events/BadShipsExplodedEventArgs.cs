namespace HW_Events
{
    public class BadShipsExplodedEventArgs : EventArgs
    {
        public int NumOfBadShips { get; set; }

        public BadShipsExplodedEventArgs(int numOfBadShips)
        {
            this.NumOfBadShips = numOfBadShips;
        }
    }
}