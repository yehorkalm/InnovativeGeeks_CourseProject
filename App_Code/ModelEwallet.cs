﻿-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class AccountInfo
{
    public string Email { get; set; }
    public Nullable<decimal> Balance { get; set; }
}

public partial class CustomerInfo
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public CustomerInfo()
    {
        this.transactions = new HashSet<transaction>();
    }

    public int CustomerID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public int AccountNo { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<transaction> transactions { get; set; }
}

public partial class Login
{
    public string Email { get; set; }
    public string Password { get; set; }
}

public partial class transaction
{
    public int transactionId { get; set; }
    public int CustomerId { get; set; }
    public string TransactionType { get; set; }
    public decimal Amount { get; set; }
    public System.DateTime TransactionTime { get; set; }
    public string Status { get; set; }

    public virtual CustomerInfo CustomerInfo { get; set; }
}
