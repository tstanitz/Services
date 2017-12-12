using System.Threading.Tasks;

namespace Shared
{
    public static class ContentProvider
    {
        public static Task<string> GetCapitalJsonAsync()
        {
            return Task.FromResult($"{{\"PhotoSets\":{{\"PhotoSet\":[{{\"Id\":\"70000000000000007\",\"Primary\":\"30000000004\",\"Title\":{{\"_Content\":\"Test photoset 2\"}},\"Description\":{{\"_Content\":\"2017. 05. 30.\"}},\"Date_Create\":\"1487704807\",\"Date_Update\":\"0\"}}," +
                $"{{\"Id\":\"70000000000000006\",\"Primary\":\"30000000004\",\"Title\":{{\"_Content\":\"Test photoset 2\"}},\"Description\":{{\"_Content\":\"2017. 05. 30.\"}},\"Date_Create\":\"1487704807\",\"Date_Update\":\"0\"}}," +
                $"{{\"Id\":\"70000000000000005\",\"Primary\":\"30000000004\",\"Title\":{{\"_Content\":\"Test photoset 2\"}},\"Description\":{{\"_Content\":\"2017. 05. 30.\"}},\"Date_Create\":\"1487704807\",\"Date_Update\":\"0\"}}," +
                $"{{\"Id\":\"70000000000000004\",\"Primary\":\"30000000004\",\"Title\":{{\"_Content\":\"Test photoset 2\"}},\"Description\":{{\"_Content\":\"2017. 05. 30.\"}},\"Date_Create\":\"1487704807\",\"Date_Update\":\"0\"}}," +
                $"{{\"Id\":\"70000000000000003\",\"Primary\":\"30000000004\",\"Title\":{{\"_Content\":\"Test photoset 2\"}},\"Description\":{{\"_Content\":\"2017. 05. 30.\"}},\"Date_Create\":\"1487704807\",\"Date_Update\":\"0\"}}," +
                $"{{\"Id\":\"70000000000000002\",\"Primary\":\"30000000004\",\"Title\":{{\"_Content\":\"Test photoset 2\"}},\"Description\":{{\"_Content\":\"2017. 05. 30.\"}},\"Date_Create\":\"1487704807\",\"Date_Update\":\"0\"}}]}}}}");
        }       
    }
}
