using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Panda.Domain
{
    public class PandaUser : IdentityUser
    {
        public PandaUser()
        {
            Packages = new List<Package>();
            Receipts = new List<Receipt>();
        }

        public ICollection<Package> Packages { get; set; }

        public ICollection<Receipt> Receipts { get; set; }
    }
}