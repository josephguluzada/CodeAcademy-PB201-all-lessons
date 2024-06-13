using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB201Interfaces
{
    public interface IAutomaticWeapon : IReloadableWeapon
    {
        void Fire();
    }
}
