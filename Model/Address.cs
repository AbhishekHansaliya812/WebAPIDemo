using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /* Class to get address (Fluent Validation) */
    public class Address
    {
        /// <summary>
        /// Street 1
        /// </summary>
        public string Street1 { get; set; }
        /// <summary>
        /// Street 2
        /// </summary>
        public string Street2 { get; set; }
        /// <summary>
        /// State
        /// </summary>
        public string State { get; set; }
        /// <summary>
        /// Country
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// City
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// Postal Code
        /// </summary>
        public string PostalCode { get; set; }
    }
}
