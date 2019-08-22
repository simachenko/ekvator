using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.IRepos;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Ninject;

namespace DAL.ReposImplement
{
    public class OrderRepos : IGenericRepos<Order>
    {
        [Inject]
        private DataBaseContext DataBase;

        public OrderRepos(DataBaseContext dataBase)
        {
            this.DataBase = dataBase;

        }
        public void Create(Order item)
        {
            DataBase.Orders.Add(item);
        }

        public async Task CreateAsync(Order item)
        {
            await DataBase.Orders.AddAsync(item);
        }

        public Order Get(int Id)
        {
            return DataBase.Orders.Find(Id);
        }

        public IEnumerable<Order> Get()
        {
            return DataBase.Orders;
        }

        public IEnumerable<Order> Get(Func<Order, bool> predicate)
        {
            return DataBase.Orders.Where(predicate);
        }

        public async Task<Order> GetAsync(int Id)
        {
            return await DataBase.Orders.FindAsync(Id);
        }

        public async Task<IEnumerable<Order>> GetAsync()
        {
            return await DataBase.Orders.ToListAsync();
        }

        public void Remove(Order item)
        {
            DataBase.Orders.Remove(item);
        }

        public void Remove(int Id)
        {
            Order item = Get(Id);
            if (item != null)
                Remove(item);
        }

        public void Update(Order item)
        {
            DataBase.Entry<Order>(item).State = EntityState.Modified;

        }
    }
}
