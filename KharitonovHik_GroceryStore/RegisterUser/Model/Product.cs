//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RegisterUser.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.Purchase = new HashSet<Purchase>();
        }
    
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Prices { get; set; }
        public string Category { get; set; }
        public string Expiration_date { get; set; }
        public string Descriptions { get; set; }
        public Nullable<int> SupplyID { get; set; }
    
        public virtual Supply Supply { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Purchase> Purchase { get; set; }
    }
}