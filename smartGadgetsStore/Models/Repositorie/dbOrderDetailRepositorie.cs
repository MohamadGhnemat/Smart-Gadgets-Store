

using Microsoft.EntityFrameworkCore;

namespace smartGadgetsStore.Models.Repositorie
{
    public class dbOrderDetailRepositorie : IRepositorie<OrderDetail>
    {
        public AppDbContext db { get; }
        public dbOrderDetailRepositorie(AppDbContext _db)
        {
            db = _db;
        }
        public void Add(OrderDetail entity)
        {
            db.OrderDetails.Add(entity);    
            db.SaveChanges();
        }

        public void Delete(int Id, OrderDetail entity)
        {
           var data = Find(Id);
            db.OrderDetails.Remove(data);
            db.SaveChanges();
        }

        public OrderDetail Find(int Id)
        {
            return db.OrderDetails.Include(x => x.Product).Include(x => x.Order).ThenInclude(O => O.User).SingleOrDefault(x => x.OrderDetailID == Id);
        }

        public void Update(int Id, OrderDetail entity)
        {
           db.OrderDetails.Update(entity);
            db.SaveChanges();
        }

        public IList<OrderDetail> View()
        {
            return db.OrderDetails.Include(x => x.Product).Include(x => x.Order).ThenInclude(O => O.User).ToList();
        }
    }
}
