using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB201Interfaces
{
    public class AK47 : Weapon, IAutomaticWeapon, IShootableWeapon
    {
        public int MagazineSize { get ; set; }
        public int CurrentAmmo { get; set; }
        public double ReloadTime { get; set; }

        public void Fire()
        {
            Console.WriteLine(CurrentAmmo = 0);
        }

        public void Reload()
        {
            Console.WriteLine(CurrentAmmo = MagazineSize);
        }

        public void Shoot()
        {
            Console.WriteLine(CurrentAmmo -= 1);
        }
    }
}
