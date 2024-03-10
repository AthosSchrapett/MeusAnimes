namespace MeusAnimes.Models;

public abstract class BaseModel()
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public DateTime CreatedAt { get; private set; } = DateTime.Now;
    public DateTime UpdatedAt { get; private set; } = DateTime.Now;
    public bool IsActive { get; private set; } = true;

    public virtual void UpdateBase()
    {
        UpdatedAt = DateTime.Now;
    }

    public virtual void ActiveStatus()
    {
        IsActive = !IsActive;
        UpdateBase();
    }
}
