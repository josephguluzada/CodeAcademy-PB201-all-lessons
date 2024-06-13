using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB201Interfaces
{
    public interface IReloadableWeapon
    {
        int MagazineSize { get; set; }
        int CurrentAmmo { get; set; }
        double ReloadTime { get; set; }
        void Reload();
    }
}
