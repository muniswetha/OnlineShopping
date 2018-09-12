using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShoppingDataAcessLayer.Views;

namespace OnlineShoppingDataAcessLayer
{
    interface IUserAccessibilityRepository
    {
        bool CreateAccount(UserDetailsViewModel userInfo);

        bool ValidateUserCredentials(ValidateUserCredentials userCreds);


    }
}
