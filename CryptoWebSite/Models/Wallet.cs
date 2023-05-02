using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CryptoWebSite.Models
{
    public class Wallet
    {
        [Key]
        public int Id { get; set; }
        public double Name { get; set; }
        public virtual ICollection<Currency> Currencies { get; set; }

    }
}
