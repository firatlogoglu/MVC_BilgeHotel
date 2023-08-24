namespace MVC_BilgeHotel.CORE.Entity
{
    public interface IEntity<T>
    {
        T ID { get; set; }
    }
}