using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Junker
{
    public class DeskQuote
    {
        private Desk desk;
        private RushOrder numDays;
        private string customerName;
        private DateTime quoteDate;
        private decimal quoteAmount;

        private const decimal BASE_PRICE = 200;
        private const decimal PRICE_PER_DRAWER = 50;
        private const decimal PRICE_PER_SQUARE_INCH = 1;
        private const decimal SURFACE_AREA_BASE_LIMIT = 1000;
        private decimal[,] rushOrderPrices = new decimal[4, 3] { { 0, 0, 0 }, { 60, 70, 80 }, { 40, 50, 60 }, { 30, 35, 40 } };
        public DeskQuote(Desk desk, RushOrder numDays, string customerName, DateTime quoteDate)
        {
            this.desk = desk;
            this.numDays = numDays;
            this.customerName = customerName;
            this.quoteDate = quoteDate;

            this.quoteAmount = computeQuoteAmount();
        }
        public Desk Desk
        {
            get { return desk; }
            set { desk = value; }
        }
        public RushOrder NumDays
        {
            get { return numDays; }
            set { numDays = value; }
        }
        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }
        public DateTime QuoteDate
        {
            get { return quoteDate; }
            set { quoteDate = value; }
        }
        public decimal QuoteAmount
        {
            get { return quoteAmount; }
            set { quoteAmount = value; }
        }

        public decimal computeQuoteAmount()
        {
            decimal surfaceArea = desk.SurfaceArea();
            decimal surfaceAreaPrice = surfaceArea > 1000 ? (surfaceArea - 1000) * PRICE_PER_SQUARE_INCH : 0;
            return BASE_PRICE + surfaceAreaPrice + desk.NumDrawers * PRICE_PER_DRAWER + (int)desk.SurfaceMaterial + computeRushOrder();
        }

        public decimal computeRushOrder()
        {
            if ((int)numDays == 0)
            {
                return 0;
            }

            if (desk.SurfaceArea() < 1000)
            {
                return rushOrderPrices[(int)numDays, 0];
            }
            else if (desk.SurfaceArea() >= 1000 && desk.SurfaceArea() <= 2000)
            {
                return rushOrderPrices[(int)numDays, 1];
            }
            else
            {
                return rushOrderPrices[(int)numDays, 2];
            }
        }
    }

    public enum RushOrder
    {
        None = 0,
        Three = 1,
        Five = 2,
        Seven = 3
    }
}
