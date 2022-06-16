using System.Linq.Expressions;

namespace _01_Framework_RepositoriesContract;

public interface IRepositoryApplication<TCreate, TUpdate, TModel, Model>
{
    void Insert(TCreate entity);
    void Update(TUpdate entity);
    void Delete(long id);
    bool Exits(long id);

    bool Exits(string entityName);

    //bool Exits(Expression<Func<TModel,bool>> expression);
    List<TModel> GetAll();
    TModel GetViewModel(long id);

    TModel Search(string entityName);
    TModel Search(Expression<Func<Model, bool>> expression);
    List<TModel> SearchAll(Expression<Func<Model, bool>> expression);
}