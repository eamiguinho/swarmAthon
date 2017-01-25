using SwarmAthon.Core.Interfaces.Models;

namespace SwarmAthon.UI.ViewModels
{
    public class TestCaseDataModel
    {
        private ITestCase _model;

        public TestCaseDataModel(ITestCase testCase)
        {
            _model = testCase;
        }
    }
}