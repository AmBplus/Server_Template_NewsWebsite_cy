namespace Server.Domain.BaseModel;

public class BaseModel<T>
{
    protected BaseModel()
    {
        CreationDate = DateTime.Now;
    }

    public T Id { get; set; }
    public DateTime CreationDate { get; set; }
}