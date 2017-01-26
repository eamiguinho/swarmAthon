using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using SwarmAthon.Core.Interfaces;
using SwarmAthon.Core.Interfaces.Models;
using SwarmAthon.Core.Interfaces.Services;
using SwarmAthon.Core.Interfaces.Services.PlatformSpecific;

namespace SwarmAthon.UI.ViewModels
{
    public class TestVersionViewModel : BaseViewModel
    {
        private readonly ITestVersionService _testVersionService;
        private readonly IUserService _userService;
        private readonly ICustomNavigationService _navigationService;
        private ObservableCollection<TestCaseDataModel> _testCases;

        public TestVersionViewModel(ITestVersionService testVersionService, IUserService userService, ICustomNavigationService navigationService)
        {
            _testVersionService = testVersionService;   
            _userService = userService;
            _navigationService = navigationService;
        }

        public ITestVersion CurrentTestVersion { get; set; }

        public ObservableCollection<TestCaseDataModel> TestCases => _testCases ?? (_testCases = new ObservableCollection<TestCaseDataModel>());

        public string Title { get; set; }

        public override async void LoadData()
        {
            var mytestUser = IoC.Container.GetInstance<IUser>();
            mytestUser.Id = 1;
            mytestUser.Name = "Emanuel";
            _userService.SetCurrentUser(mytestUser);
            var tests = await _testVersionService.GetTestsForCurrentVersion();
            if (tests.IsOk)
            {
                CurrentTestVersion = tests.Data;
                Title = "Testing version " + tests.Data.Name;
                foreach (var testCase in tests.Data.TestCases)
                {
                    TestCases.Add(new TestCaseDataModel(testCase));
                }
            }
            base.LoadData();
        }

        public void TestCompleted()
        {
            _testVersionService.SubmitTest(CurrentTestVersion);
        }

        public void SetCurrentTestCaseAndNavigate(TestCaseDataModel item)
        {
            _testVersionService.SetCurrentTestCase(item.Model);
            _navigationService.NavigateToTestCase();
        }
    }
}
