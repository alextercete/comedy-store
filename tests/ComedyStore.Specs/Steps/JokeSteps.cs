using System.Linq;
using ComedyStore.Core.Jokes;
using TechTalk.SpecFlow;

namespace ComedyStore.Specs.Steps
{
    [Binding]
    internal class JokeSteps
    {
        private readonly UserContext _user;
        private readonly JokeRepository _jokeRepository;

        private static Joke ShownJoke
        {
            set { ScenarioContext.Current.Set(value); }
        }

        public JokeSteps(UserContext user, JokeRepository jokeRepository)
        {
            _user = user;
            _jokeRepository = jokeRepository;
        }

        [Given(@"there are jokes available")]
        public void Given_there_are_jokes_available()
        {
            var availableJokes = _user.SeenJokeIds.Concat(_user.UnseenJokeIds).Select(id => new Joke {Id = id});
            _jokeRepository.CreateJokes(availableJokes);
        }

        [When(@"I ask to see a random joke")]
        public void When_I_ask_to_see_a_random_joke()
        {
            ShownJoke = _jokeRepository.GetRandomJoke(_user.Email);
        }
    }
}
