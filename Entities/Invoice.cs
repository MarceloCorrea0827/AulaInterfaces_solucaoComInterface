using System.Globalization;

namespace SolSemInterface.Entities
{
    class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }
        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        // Propriedade Calculada
        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            return "Basic payment"
                + BasicPayment.ToString("F2", CultureInfo.InvariantCulture)
                + "\Tax: "
                + Tax.ToString("F2", CultureInfo.InvariantCulture)
                + "\Total payment: "
                + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
