using Prism.Events;
using Unheard.Model.Security;

namespace Unheard.Messages.Security
{
    public class LoginMessage : PubSubEvent<UserProfile>
    {
    }
}
