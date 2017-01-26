using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SwarmAthon.Core.Interfaces;
using SwarmAthon.Core.Interfaces.DataServices;
using SwarmAthon.Core.Interfaces.Models;
using SwarmAthon.DataServices.Online.Dto;
using SwarmAthon.DataServices.Online.Factories;

namespace SwarmAthon.DataServices.Online.Tests
{
    public class TestVersionOnlineDataService : ITestVersionOnlineDataService
    {
        public Task SaveTestVersion(ITestVersion testVersion, IUser user)
        {
            throw new System.NotImplementedException();
        }

        public async Task<DataResult<ITestVersion>> GetCurrenTestVersion()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var res = await client.GetAsync("http://swarmathonapi-dev.eu-west-1.elasticbeanstalk.com/cases");
                    if (res.IsSuccessStatusCode)
                    {
                        var resData = await res.Content.ReadAsStringAsync();
                        var parsedData = TestVersionDtoFactory.Create(JsonConvert.DeserializeObject<TestVersionDto>(resData));
                        if (parsedData != null)
                        {
                            return new DataResult<ITestVersion>(parsedData);
                        }
                        else
                        {
                            return new DataResult<ITestVersion>(Result.Error);
                        }
                    }
                    else
                    {
                        return new DataResult<ITestVersion>(res.StatusCode.ToString());
                    }
                }
            }
            catch (Exception e)
            {
                return new DataResult<ITestVersion>(e);
            }
        }

        public async Task<DataResult<bool>> SubmitTest(ITestVersion currentTestVersion, IUser getCurrentUser)
        {
            try
            {
                using (HttpClient client = new HttpClient()) { 
                    var obj = VersionSubmitDtoFactory.Create(currentTestVersion, getCurrentUser);
                    var str = JsonConvert.SerializeObject(obj);
                var res = await client.PostAsync("http://swarmathonapi-dev.eu-west-1.elasticbeanstalk.com/result", new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json"));
                if (res.IsSuccessStatusCode)
                {
                    return new DataResult<bool>(true);
                }
                else
                {
                    return new DataResult<bool>(res.StatusCode.ToString());
                }
                }
            }
            catch (Exception e)
            {
                return new DataResult<bool>(e);
            }
        }
    }
}
