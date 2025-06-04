
using Microsoft.EntityFrameworkCore;

namespace smartGadgetsStore.Models.Repositorie
{
    public class dbOrderRepositorie : IRepositorie<Order>
    {
        public AppDbContext db { get; }
        public dbOrderRepositorie(AppDbContext _db)
        {
           db = _db; 
        }
        public void Add(Order entity)
        {
           db.Orders.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int Id, Order entity)
        {
            var data = Find(Id);
            db.Orders.Remove(data);
            db.SaveChanges();
        }

        public Order Find(int Id)
        {
            return db.Orders.Include(x => x.User).SingleOrDefault(x => x.OrderID == Id);
        }

        public void Update(int Id, Order entity)
        {
            db.Orders.Update(entity);
            db.SaveChanges();
        }

        public IList<Order> View()
        {
            return db.Orders.Include(x=>x.User).ToList();
        }
    }
}
