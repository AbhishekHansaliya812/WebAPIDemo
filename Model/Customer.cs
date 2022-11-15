using Model.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Model
{
    /* Class to get customer Details (Fluent Validation) */
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public long Phone { get; set; }
        public Address Address { get; set; }
    }
}
