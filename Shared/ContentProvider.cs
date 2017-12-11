using System.Threading.Tasks;

namespace Shared
{
    public static class ContentProvider
    {
        public static Task<string> GetCapitalJsonAsync(int id)
        {
            return Task.FromResult($"{{\"PhotoSets\":{{\"PhotoSet\":[{{\"Id\":\"{id}\",\"Primary\":\"30000000004\",\"Title\":{{\"_Content\":\"Test photoset 2\"}},\"Description\":{{\"_Content\":\"2017. 05. 30.\"}},\"Date_Create\":\"1487704807\",\"Date_Update\":\"0\"}}," +
                $"{{\"Id\":\"{id}\",\"Primary\":\"30000000004\",\"Title\":{{\"_Content\":\"Test photoset 2\"}},\"Description\":{{\"_Content\":\"2017. 05. 30.\"}},\"Date_Create\":\"1487704807\",\"Date_Update\":\"0\"}}," +
                $"{{\"Id\":\"{id}\",\"Primary\":\"30000000004\",\"Title\":{{\"_Content\":\"Test photoset 2\"}},\"Description\":{{\"_Content\":\"2017. 05. 30.\"}},\"Date_Create\":\"1487704807\",\"Date_Update\":\"0\"}}," +
                $"{{\"Id\":\"{id}\",\"Primary\":\"30000000004\",\"Title\":{{\"_Content\":\"Test photoset 2\"}},\"Description\":{{\"_Content\":\"2017. 05. 30.\"}},\"Date_Create\":\"1487704807\",\"Date_Update\":\"0\"}}," +
                $"{{\"Id\":\"{id}\",\"Primary\":\"30000000004\",\"Title\":{{\"_Content\":\"Test photoset 2\"}},\"Description\":{{\"_Content\":\"2017. 05. 30.\"}},\"Date_Create\":\"1487704807\",\"Date_Update\":\"0\"}}," +
                $"{{\"Id\":\"{id}\",\"Primary\":\"30000000004\",\"Title\":{{\"_Content\":\"Test photoset 2\"}},\"Description\":{{\"_Content\":\"2017. 05. 30.\"}},\"Date_Create\":\"1487704807\",\"Date_Update\":\"0\"}}]}}}}");
        }       
    }
}
