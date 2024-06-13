using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB201Interfaces
{
    public class Deagle : Weapon, IShootableWeapon
    {
        public int MagazineSize { get; set; }
        public int CurrentAmmo { get; set; }
        public double ReloadTime { get; set; }

        public void Shoot()
        {
            CurrentAmmo -= 1;
        }

        public void Reload()
        {
            Console.WriteLine(CurrentAmmo = MagazineSize);
        }
    }
}
