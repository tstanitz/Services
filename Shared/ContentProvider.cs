using System.Threading.Tasks;

namespace Shared
{
    public static class ContentProvider
    {
        public static Task<string> GetJsonAsync()
        {
            return Task.FromResult("{\"photosets\":{\"cancreate\":1,\"page\":1,\"pages\":1,\"perpage\":5,\"total\":2,\"photoset\":[" +
           "{\"id\":\"70000000000000006\",\"primary\":\"30000000003\",\"secret\":\"secret\",\"server\":\"100\",\"farm\":1,\"photos\":2,\"videos\":\"0\",\"title\":{\"_content\":\"Test photoset 1\"},\"description\":{\"_content\":\"2017. 05. 30. - 2017. 05. 31.\"},\"needs_interstitial\":0,\"visibility_can_see_set\":1,\"count_views\":\"0\",\"count_comments\":\"0\",\"can_comment\":1,\"date_create\":\"1488385423\",\"date_update\":\"1488824376\"}," +
           "{\"id\":\"70000000000000005\",\"primary\":\"30000000004\",\"secret\":\"secret\",\"server\":\"100\",\"farm\":1,\"photos\":1,\"videos\":\"0\",\"title\":{\"_content\":\"Test photoset 2\"},\"description\":{\"_content\":\"2017. 05. 30.\"},\"needs_interstitial\":0,\"visibility_can_see_set\":1,\"count_views\":\"0\",\"count_comments\":\"0\",\"can_comment\":1,\"date_create\":\"1487704807\",\"date_update\":\"0\"}]}"+
           ",\"stat\":\"ok\"}");
        }
    }
}
