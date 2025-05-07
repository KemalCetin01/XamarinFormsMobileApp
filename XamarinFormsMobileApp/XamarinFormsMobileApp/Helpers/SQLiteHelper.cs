using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinFormsMobileApp.DataModel;

namespace XamarinFormsMobileApp.Helpers
{
    public class SQLiteHelper
    {
        public readonly SQLiteAsyncConnection db;

        public SQLiteHelper(string dbPath)
        {
            db=new SQLiteAsyncConnection(dbPath);
            db.CreateTableAsync<EmployeeModel>();
        }

        public async Task<int> CreateEmployeesAsync(EmployeeModel employee)
        {
            return await db.InsertAsync(employee);
        }
        public async Task<List<EmployeeModel>> ReadEmployeesAsync()
        {
            return await db.Table<EmployeeModel>().ToListAsync();
        }
        public async Task<int> UpdateEmployeesAsync(EmployeeModel employee)
        {
            return await db.UpdateAsync(employee);
        }
        public async Task<int> DeleteEmployeesAsync(EmployeeModel employee)
        {
            return await db.DeleteAsync(employee);
        }

        public async Task<List<EmployeeModel>> Search(string search)
        {
           return await db.Table<EmployeeModel>().Where(x => x.Name.ToLower().Contains(search.ToLower())).ToListAsync();
        }
    }
}
