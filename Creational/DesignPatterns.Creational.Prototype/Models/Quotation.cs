namespace DesignPatterns.Creational.Prototype.Models
{
    using System;

    file class Quotation : IQuotation
    {
        // Private fields to store the prototype data
        private int id;
        private string code;
        private decimal amountPayable;
        private DateTime validTill;

        // Public properties to access the data
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        public decimal AmountPayable
        {
            get { return amountPayable; }
            set { amountPayable = value; }
        }

        public DateTime ValidTill
        {
            get { return validTill; }
            set { validTill = value; }
        }

        // Constructor to initialize the prototype data
        public Quotation(int id, string code, decimal amountPayable, DateTime validTill)
        {
            this.id = id;
            this.code = code;
            this.amountPayable = amountPayable;
            this.validTill = validTill;
        }

        // Clone method to create a deep copy using the prototype pattern
        public object Clone()
        {
            // Creating a new instance of Quotation using the prototype data
            return new Quotation(this.id, this.code, this.amountPayable, this.validTill);
        }

    }

    public class QuoteService : IQuoteService
    {
        public IQuotation Create(int id, string code, decimal amountPayable, DateTime validTill)
        {
            return new Quotation(id, code, amountPayable, validTill);
        }
    }


}
