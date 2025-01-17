using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Notifications;

namespace Quiz.Site.Notifications;

public class ProfileUpdatedNotification : INotification
{
    public IMember UpdatedBy { get; }

    public ProfileUpdatedNotification(IMember updatedBy)
    {
        UpdatedBy = updatedBy;
    }
}