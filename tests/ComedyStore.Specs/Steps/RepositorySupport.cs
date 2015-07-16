using BoDi;
using ComedyStore.Core.Jokes;
using ComedyStore.Core.Users;
using TechTalk.SpecFlow;

namespace ComedyStore.Specs.Steps
{
    [Binding]
    internal class RepositorySupport
    {
        private readonly IObjectContainer _container;

        public RepositorySupport(IObjectContainer container)
        {
            _container = container;
        }

        [Before]
        public void InitializeRepositories()
        {
            var jokeRepository = new JokeRepository();
            var userRepository = new UserRepository();

            _container.RegisterInstanceAs(jokeRepository);
            _container.RegisterInstanceAs(userRepository);
        }
    }
}