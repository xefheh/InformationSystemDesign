using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystemDesign.Interfaces
{
    public interface IPermissionAction
    {
        bool CanRemoveCard();
        bool CanAddCard();
        bool CanUpdateCard();
    }
}
