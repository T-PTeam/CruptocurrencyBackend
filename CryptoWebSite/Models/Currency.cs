using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CryptoWebSite.Models
{
    public class Currency
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public decimal PurchaseValue { get; set; }
        public decimal SaleValue { get; set; }
        [ForeignKey("WalletId")]
        public virtual Wallet Wallet { get; set; }
    }
}
