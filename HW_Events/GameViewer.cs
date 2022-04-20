using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Events
{
    internal class GameViewer
    {
        public void GoodSpaceShipHpChangedEventHandler(object sender, PointEventArgs pointEventArgs)
        {
            Console.WriteLine($"your points: {pointEventArgs.Points}");
        }

        public void GoodSpaceShipLocationChangedEventHandler(object sender, LocationEventArgs locationEventArgs)
        {
            Console.WriteLine($"new location: x: {locationEventArgs.X}. y: {locationEventArgs.Y}.");
        }
    }
}
