namespace smartGadgetsStore.Models.Repositorie
{
    public interface IRepositorie<TEntity>
    {
        //EF 
        IList<TEntity> View();  //Select * from table 
        void Add(TEntity entity);  //Insert
        void Update(int Id, TEntity entity); //Update
        void Delete(int Id, TEntity entity);   //Delete
        TEntity Find(int Id);   // Select * from table where ID = .
    }
}
