namespace BackendAwSmartstay.API.shared.Domain.Repositories;

public interface IUnitOfWork
{
    Task CompleteAsync();
}