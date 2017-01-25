using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SwarmAthon.Core.Interfaces;
using SwarmAthon.Core.Interfaces.DataServices;
using SwarmAthon.Core.Interfaces.Models;
using SwarmAthon.DataServices.Online.Factories;

namespace SwarmAthon.DataServices.Online
{
    public class TestVersionOnlineDataService : ITestVersionOnlineDataService
    {
        public Task SaveTestVersion(ITestVersion testVersion, IUser user)
        {
            throw new System.NotImplementedException();
        }

        public Task<ITestVersion> GetCurrenTestVersion()
        {
            throw new System.NotImplementedException();
        }

        public async Task<DataResult<bool>> SubmitTest(ITestVersion currentTestVersion, IUser getCurrentUser)
        {
            try
            {
                HttpClient client = new HttpClient();
                var obj = VersionSubmitDtoFactory.Create(currentTestVersion, getCurrentUser);
                var res = await client.PostAsync("http://swarmathonapi-dev.eu-west-1.elasticbeanstalk.com/result", new StringContent(JsonConvert.SerializeObject(obj)));
                if (res.IsSuccessStatusCode)
                {
                    return new DataResult<bool>(true);
                }
                else
                {
                    return new DataResult<bool>(res.StatusCode.ToString());
                }
            }
            catch (Exception e)
            {
                return new DataResult<bool>(e);
            }
        }
    }
}
