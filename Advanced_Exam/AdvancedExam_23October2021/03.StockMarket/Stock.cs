﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket
{
    public class Stock
    {
        public Stock(string companyName, string director, decimal pricePerShare, int totalNumberOfShares)
        {
            CompanyName = companyName;
            Director = director;
            PricePerShare = Math.Abs(pricePerShare);
            TotalNumberOfShares = totalNumberOfShares;
        }
        public string CompanyName { get; set; }
        public string Director { get; set; }
        public decimal PricePerShare { get; set; }
        public int TotalNumberOfShares { get; set; }
        public decimal MarketCapitalization { get { return PricePerShare * TotalNumberOfShares; } }
        public override string ToString()
        {
            return $"Company: {CompanyName}{Environment.NewLine}Director: {Director}{Environment.NewLine}" +
                $"Price per share: ${PricePerShare}{Environment.NewLine}Market capitalization: ${MarketCapitalization}";
        }
    }
}
