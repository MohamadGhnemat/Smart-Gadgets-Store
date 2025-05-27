
namespace smartGadgetsStore.Models.Repositorie
{
    public class dbUserTypeRepositorie : IRepositorie<UserType>
    {
        public AppDbContext db { get; }
        public dbUserTypeRepositorie(AppDbContext _db)
        {
           db = _db; 
        }
        public void Add(UserType entity)
        {
          db.UserTypes.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int Id, UserType entity)
        {
           var data = Find(Id);
            db.UserTypes.Remove(data);
            db.SaveChanges();
        }

        public UserType Find(int Id)
        {
            return db.UserTypes.SingleOrDefault(x => x.UserTypeID == Id);
        }

        public void Update(int Id, UserType entity)
        {
            db.UserTypes.Update(entity);
            db.SaveChanges();
        }

        public IList<UserType> View()
        {
            return db.UserTypes.ToList();
        }
    }
}
