using ComedyStore.Core.Jokes;
using ComedyStore.Core.Users;
using Shouldly;
using TechTalk.SpecFlow;

namespace ComedyStore.Specs.Steps
{
    [Binding]
    internal class UserSteps
    {
        private readonly UserContext _user;
        private readonly UserRepository _userRepository;

        private static Joke ShownJoke
        {
            get { return ScenarioContext.Current.Get<Joke>(); }
        }

        public UserSteps(UserContext user, UserRepository userRepository)
        {
            _user = user;
            _userRepository = userRepository;
        }

        [Given(@"I am a user")]
        public void Given_I_am_a_user()
        {
            _userRepository.CreateUser(_user.Email, new User());
        }

        [Given(@"I have already seen some of the available jokes")]
        public void Given_I_have_already_seen_some_of_the_available_jokes()
        {
            foreach (var jokeId in _user.SeenJokeIds)
            {
                _userRepository.AddSeenJoke(_user.Email, jokeId);
            }
        }

        [Then(@"the shown joke should be new to me")]
        public void Then_the_shown_joke_should_be_new_to_me()
        {
            _user.UnseenJokeIds.ShouldContain(ShownJoke.Id);
        }
    }
}
