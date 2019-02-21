using System;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Core.Tests.Mock;
using Aliyun.Acs.Core.Tests.Mock.Service.Iot;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Feature.Fixed
{
    public class IotListProductByTags
    {
        [Fact]
        public void TestName()
        {
            // Create a client used for initiating a request
            IClientProfile profile = DefaultProfile.GetProfile(
                "LTAIlQ34XvjmGPBt",
                "LX1MXn6ZhCwACMscvGwJlwKNC4qao5",
                "cn-hangzhou");
            DefaultAcsClient client = new DefaultAcsClient(profile);

            // try
            // {
            // Create the request
            ListProductByTagsRequest request = new ListProductByTagsRequest();

            // Initiate the request and get the response
            ListProductByTagsResponse response = client.GetAcsResponse(request);
            System.Console.WriteLine(response);
            // }
            // catch (ServerException ex)
            // {
            //     System.Console.WriteLine(ex.ToString());
            // }
            // catch (ClientException ex)
            // {
            //     System.Console.WriteLine(ex.ToString());
            // }
        }
    }
}
