using Prism.Events;
using PrismAppExample.Model.Security;
using Unheard.Model.Security;

namespace PrismAppExample.Messages.Security
{
    public class LoginMessage : PubSubEvent<UserProfile>
    {
    }
}
