using SwarmAthon.Core.Interfaces.Services;

namespace SwarmAthon.UI.ViewModels  
{
    public class TestCaseViewModel : BaseViewModel
    {
        private readonly ITestVersionService _testVersionService;

        public TestCaseViewModel(ITestVersionService testVersionService)
        {
            _testVersionService = testVersionService;
        }

        public TestCaseDataModel CurrentTestCase { get; set; }

        public override void LoadData()
        {
            CurrentTestCase = new TestCaseDataModel(_testVersionService.GetCurrentTestCase());
            base.LoadData();
        }
    }
}