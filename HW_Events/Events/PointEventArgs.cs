namespace HW_Events
{
    public class PointEventArgs : EventArgs
    {
        public int Points { get; set; }

        public PointEventArgs(int points)
        {
            Points = points;
        }
    }
}