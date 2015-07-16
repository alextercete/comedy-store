using System.Collections.Generic;

namespace ComedyStore.Specs.Steps
{
    internal class UserContext
    {
        public readonly string Email;
        public readonly IList<string> SeenJokeIds;
        public readonly IList<string> UnseenJokeIds;

        public UserContext()
        {
            Email = "coyote@acme.com";
            SeenJokeIds = new[] {"1", "3", "5"};
            UnseenJokeIds = new[] {"2", "4"};
        }
    }
}