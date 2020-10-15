using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WePrint.Data
{
    public class Customer : IdentityUser
    {

        public DateTime LastLogged { get; set; }

    }
}
