using money.data.Seeds.Interfaces;
using money.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace money.data.Seeds
{
    public class CategorySeedData : ISeedData<CategoryMaster>
    {
        public List<CategoryMaster> AddSeedData()
        {
            return new List<CategoryMaster>()
            {
                new CategoryMaster
                {
                    Id = 1,
                    CategoryName = "Others",
                    TransactionTypeId = 1,
                    Description = "Miscellaneous sources",
                    Color = "",
                    Icon = "",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new CategoryMaster
                {
                    Id = 2,
                    CategoryName = "Salary",
                    TransactionTypeId = 1,
                    Description = "Monthly salary",
                    Color = "",
                    Icon = "",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new CategoryMaster
                {
                    Id = 3,
                    CategoryName = "Sold items",
                    TransactionTypeId = 1,
                    Description = "Items sold / services provided",
                    Color = "",
                    Icon = "",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new CategoryMaster
                {
                    Id = 4,
                    CategoryName = "Coupons",
                    TransactionTypeId = 1,
                    Description = "Gift vouchers, coupons, cashbacks",
                    Color = "",
                    Icon = "",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new CategoryMaster
                {
                    Id = 5,
                    CategoryName = "Dividend",
                    TransactionTypeId = 1,
                    Description = "Dividend stock incomes",
                    Color = "",
                    Icon = "",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new CategoryMaster
                {
                    Id = 6,
                    CategoryName = "Others",
                    TransactionTypeId = 2,
                    Description = "Miscellaneous expenses",
                    Color = "",
                    Icon = "",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new CategoryMaster
                {
                    Id = 7,
                    CategoryName = "Food and Dining",
                    TransactionTypeId = 2,
                    Description = "Groceries, restaurant bills etc",
                    Color = "",
                    Icon = "",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new CategoryMaster
                {
                    Id = 8,
                    CategoryName = "Shopping",
                    TransactionTypeId = 2,
                    Description = "Apparels, appliances shopping etc",
                    Color = "",
                    Icon = "",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new CategoryMaster
                {
                    Id = 9,
                    CategoryName = "Travelling",
                    TransactionTypeId = 2,
                    Description = "Bus tickets, train tickets, fuel bills etc",
                    Color = "",
                    Icon = "",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new CategoryMaster
                {
                    Id = 10,
                    CategoryName = "Entertainment",
                    TransactionTypeId = 2,
                    Description = "Movie tickets, amusement rides, OTT subscriptions",
                    Color = "",
                    Icon = "",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new CategoryMaster
                {
                    Id = 11,
                    CategoryName = "Medical",
                    TransactionTypeId = 2,
                    Description = "Doctor bills, medical bills etc",
                    Color = "",
                    Icon = "",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new CategoryMaster
                {
                    Id = 12,
                    CategoryName = "Personal Care",
                    TransactionTypeId = 2,
                    Description = "skin care, cosmetics, haircut etc",
                    Color = "",
                    Icon = "",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new CategoryMaster
                {
                    Id = 13,
                    CategoryName = "Education",
                    TransactionTypeId = 2,
                    Description = "Tution fees, school fees, online courses etc",
                    Color = "",
                    Icon = "",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new CategoryMaster
                {
                    Id = 14,
                    CategoryName = "Bills and Utilities",
                    TransactionTypeId = 2,
                    Description = "Gas, electricity, water, internet bills etc",
                    Color = "",
                    Icon = "",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new CategoryMaster
                {
                    Id = 15,
                    CategoryName = "Investments",
                    TransactionTypeId = 2,
                    Description = "Stocks, mutual funds, deposits etc",
                    Color = "",
                    Icon = "",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new CategoryMaster
                {
                    Id = 16,
                    CategoryName = "Rent",
                    TransactionTypeId = 2,
                    Description = "House rent, shop rent etc",
                    Color = "",
                    Icon = "",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new CategoryMaster
                {
                    Id = 17,
                    CategoryName = "Taxes",
                    TransactionTypeId = 2,
                    Description = "Income tax, house tax etc",
                    Color = "",
                    Icon = "",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new CategoryMaster
                {
                    Id = 18,
                    CategoryName = "Insurance",
                    TransactionTypeId = 2,
                    Description = "Insurance premiums",
                    Color = "",
                    Icon = "",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new CategoryMaster
                {
                    Id = 19,
                    CategoryName = "Gifts and Donation",
                    TransactionTypeId = 2,
                    Description = "Gifts, donations etc",
                    Color = "",
                    Icon = "",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                }
            };
        }
    }
}
