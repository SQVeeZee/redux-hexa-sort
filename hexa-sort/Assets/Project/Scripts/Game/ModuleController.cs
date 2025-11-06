using VContainer;
using VContainer.Unity;

namespace Project
{
    public class ModuleController : IStartable
    {
        private readonly LevelService _levelService;

        [Inject]
        private ModuleController(LevelService levelService)
        {
            _levelService = levelService;
        }

        void IStartable.Start()
        {
            _levelService.CreateLevel();
        }
    }
}