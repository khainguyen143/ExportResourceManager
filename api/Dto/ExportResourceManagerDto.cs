using System.Collections.Generic;

namespace ExportResourceManager.Dto
{
    public class ExportResourceManagerDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ResourceFileId { get; set; }   
        public string EditingSoftware { get; set; }  
        public List<string> UsedByUrls { get; set; }

        public List<ResourceDto> ResourceDtos { get; set; }
    }
    public class ResourceDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ResourceFileId { get; set; }
        public long StartTime { get; set; }
        public long EndTime { get; set; }
    }
}
