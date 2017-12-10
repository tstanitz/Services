using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Domain
{
    public class PhotoSetsDataResult
    {
        public PhotoSetsData PhotoSets { get; set; }
        public string ActionName { get; set; }
    }

    public class PhotoSetsData
    {
        public List<PhotoSetData> PhotoSet { get; set; }
    }

    public class PhotoSetData
    {
        public string Id { get; set; }
        public string Primary { get; set; }
        public ContentData Title { get; set; }
        public ContentData Description { get; set; }
        public string Date_Create { get; set; }
        public string Date_Update { get; set; }
    }

    public class ContentData
    {
        public string _Content { get; set; }
    }

}
