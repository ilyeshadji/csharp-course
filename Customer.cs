using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace CSharpMasterclass
{
    public class Customer
    {
        private static int cNumber = 0;
        private readonly int _id; // can only get set once

        public string Name { get; set; }

        public int Id => _id;

        public Customer()
        {
            _id = cNumber++;
        }
    }
}