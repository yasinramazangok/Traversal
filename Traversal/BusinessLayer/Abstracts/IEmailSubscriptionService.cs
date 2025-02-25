using Traversal.EntityLayer.Concretes;

namespace Traversal.BusinessLayer.Abstracts
{
    public interface IEmailSubscriptionService : IGenericReadonlyService<EmailSubscription, EmailSubscription, object>, IGenericWriteService<EmailSubscription, object>
    {
    }
}
