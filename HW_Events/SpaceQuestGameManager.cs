using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Events
{
    internal class SpaceQuestGameManager
    {
        private int goodSpaceShipHitPoint;
        private int shipXLocation;
        private int shipYLocation;
        private int numberOfBadShips;
        private int currentLevel;

        public event EventHandler<PointEventArgs> HpChanged;
        public event EventHandler<LocationEventArgs> GoodSpaceShipLocationChanged;
        public event EventHandler<GoodShipExplodedEventArgs> GoodSpaceShipDestroyed;
        public event EventHandler<BadShipsExplodedEventArgs> BadShipsExploded;
        public event EventHandler<LevelEventArgs> LevelUpReached;

        public SpaceQuestGameManager(int goodSpaceShipHitPoint, int shipXLocation, int shipYLocation, int numberOfBadShips)
        {
            this.goodSpaceShipHitPoint = goodSpaceShipHitPoint;
            this.shipXLocation = shipXLocation;
            this.shipYLocation = shipYLocation;
            this.numberOfBadShips = numberOfBadShips;
        }

        public void MoveSpaceShip(int newX, int newY)
        {
            shipXLocation = newX;
            shipYLocation = newY;
            OnLocationChanged(newX, newY);
        }

        public void ShipGotDamaged(int damage)
        {
            goodSpaceShipHitPoint -= damage;
            OnHpChanged(damage);
        }

        public void ShipGotExtraHP(int extraHP)
        {
            goodSpaceShipHitPoint += extraHP;
            OnHpChanged(extraHP);
        }
        public void ShipDestroyed()
        {
            OnGoodSpaceShipDestroyed();
        }
        public void NumOfBadShipsExploded(int numOfBadShips)
        {
            numberOfBadShips -= numOfBadShips;
            OnNumOfBadShipsExploded(numOfBadShips);
        }

        private void OnHpChanged(int hp)
        {
            HpChanged?.Invoke(this, new PointEventArgs(hp));
        }

        private void OnLocationChanged(int x, int y)
        {
            GoodSpaceShipLocationChanged?.Invoke(this, new LocationEventArgs(x, y));
        }
        private void OnGoodSpaceShipDestroyed()
        {
            GoodSpaceShipDestroyed?.Invoke(this, new GoodShipExplodedEventArgs());
        }
        private void OnNumOfBadShipsExploded(int numOfBadShips)
        {
            BadShipsExploded?.Invoke(this, new BadShipsExplodedEventArgs(numOfBadShips));
        }
    }
}
