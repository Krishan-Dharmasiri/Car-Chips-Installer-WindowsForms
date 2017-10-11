using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chips.Installer.Engine.Interfaces
{
    public interface IChipManager
    {
        int GetMinimumChipsRequired(IDictionary<string, string> parameters);
    }
}
