

namespace Server.EFcore.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly Context Context;

    public UnitOfWork(Context context)
    {
        Context = context;
    }


    public void Save()
    {
        Context.SaveChanges();
    }
}