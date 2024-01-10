using ErpOnClick.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.ErpMain.Models
{
    public class DashboardViewModel
    {
        public int CustomerActive { get; set; }
        public int CustomerInActive { get; set; }
        public int VendorActive { get; set; }
        public int VendorInActive { get; set; }
        public List<AccountByType> AccountByTypes { get; set; }
        public List<ItemByCategory> ItemByCategory { get; set; }
        public List<TrailBalnceByAccount> TrailBalnceByAccount { get; set; }

        public void Build(List<Customers> customers,List<Vendors> vendors,List<AccountTypes> accountTypes,List<Accounts> accounts,  List<ItemCategories> itemCategories, List<Items> items, List<IGrouping<Accounts, GeneralEntriesLines>> generalEntriesList = null)
        {
            this.CustomerActive = customers.Where(c => c.ActiveStatus == "015001").Count();
            this.CustomerInActive = customers.Where(c => c.ActiveStatus == "015002").Count();
            this.VendorActive = vendors.Where(c => c.ActiveStatus == "015001").Count();
            this.VendorInActive = vendors.Where(c => c.ActiveStatus == "015002").Count();


            List<AccountByType> listofaccountbytype = new List<AccountByType>();
            foreach (var typeofaccount in accountTypes)
            {
                AccountByType accountByTypes = new AccountByType();

                accountByTypes.AccountCount = accounts.Where(c => c.AccountTypeId == typeofaccount.AccountTypeId).Count();
                accountByTypes.AccountType = typeofaccount.AccountTypeNameEn;
                listofaccountbytype.Add(accountByTypes);
            }
            this.AccountByTypes = listofaccountbytype;


            List<TrailBalnceByAccount> listReportTrailBalance = new List<TrailBalnceByAccount>();
            foreach (var item in generalEntriesList)
            {
                TrailBalnceByAccount reportObject = new TrailBalnceByAccount();

                reportObject.Value = Convert.ToInt32(item.Sum(x => x.Debit) - item.Sum(x => x.Credit));
                reportObject.Account = item.Select(x => x.Account.AccountNameEn).FirstOrDefault();

                listReportTrailBalance.Add(reportObject);
            }
            this.TrailBalnceByAccount = listReportTrailBalance.OrderBy(c => c.Account).ToList();



            List<ItemByCategory> listofitembycategory = new List<ItemByCategory>();
            foreach (var categoriesofitem in itemCategories)
            {
                ItemByCategory itemByCategory = new ItemByCategory();
                itemByCategory.Category = categoriesofitem.ItemCategoryNameEn;
                itemByCategory.Count = items.Where(c => c.ItemCategoryId == categoriesofitem.ItemCategoryId).Count();
                listofitembycategory.Add(itemByCategory);
            }
            this.ItemByCategory = listofitembycategory;
        }
    }

    

    public class AccountByType
    {
        public string AccountType { get; set; }
        public int AccountCount { get; set; }
    }

    public class ItemByCategory
    {
        public string Category { get; set; }
        public int Count { get; set; }
    }

    public class TrailBalnceByAccount
    {
        public string Account { get; set; }
        public int Value { get; set; }
    }
}
