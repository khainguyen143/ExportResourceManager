using API.Constants;
using API.Models;
using API.Models.Authorization;
using System;
using System.Collections.Generic;

namespace ExportVideoManager.Models.ProcessingResource
{
    // lưu các thông tin về tài nguyên để nếu mất dữ liệu phía app tài nguyên 
    public class Resource : BaseModel
    {
        public string Description { get; set; }
        public string ResourceFileId { get; set; }
        public ResourceType ResourceType { get; set; }
        public bool IsProvenOrigin { get; set; } // là tài nguyên được cty quản lý hay chưa
        public long Size { get; set; }
        public long StartTime { get; set; }
        public long EndTime { get; set; }


        // download sources
        public List<string> DownloadSourceUrls { get; set; } // lấy từ app tài nguyên

        // credit
        public bool RequiredCredit { get; set; } // lấy từ app tài nguyên
        public string Credit { get; set; } // lấy từ app tài nguyên

        public List<ResourceEditorial> ResourceEditorials { get; set; }

        public void SetResourceFileId(string resourceFileId)
        {
            try
            {
                resourceFileId = resourceFileId?.Trim();

                // check resource file Id is valid
                if (!string.IsNullOrEmpty(resourceFileId) && resourceFileId.Length == ResourceConst.ResourceFileIdLength)
                {
                    switch (ResourceType)
                    {
                        case ResourceType.Video:
                            if (resourceFileId.StartsWith(ResourceConst.ResourceFileId_VideoPrefix))
                            {
                                ResourceFileId = resourceFileId;
                                IsProvenOrigin = true;
                            }
                            else
                            {
                                ResourceFileId = ResourceConst.ResourceFileId_VideoPrefix+ Guid.NewGuid();
                                IsProvenOrigin = false;
                            }
                            break;
                        case ResourceType.Audio:
                            if (resourceFileId.StartsWith(ResourceConst.ResourceFileId_AudioPrefix))
                            {
                                ResourceFileId = resourceFileId;
                                IsProvenOrigin = true;
                            }
                            else
                            {
                                ResourceFileId = ResourceConst.ResourceFileId_AudioPrefix + Guid.NewGuid();
                                IsProvenOrigin = false;
                            }
                            break;
                        case ResourceType.Image:
                            if (resourceFileId.StartsWith(ResourceConst.ResourceFileId_ImagePrefix))
                            {
                                ResourceFileId = resourceFileId;
                                IsProvenOrigin = true;
                            }
                            else
                            {
                                ResourceFileId = ResourceConst.ResourceFileId_ImagePrefix + Guid.NewGuid();
                                IsProvenOrigin = false;
                            }
                            break;
                        case ResourceType.ThirdParty:
                            if (resourceFileId.StartsWith(ResourceConst.ResourceFileId_ThirdPartyPrefix))
                            {
                                ResourceFileId = resourceFileId;
                                IsProvenOrigin = true;
                            }
                            else
                            {
                                ResourceFileId = ResourceConst.ResourceFileId_ThirdPartyPrefix + Guid.NewGuid();
                                IsProvenOrigin = false;
                            }
                            break;
                        case ResourceType.Editotial:
                            if (resourceFileId.StartsWith(ResourceConst.ResourceFileId_EditorialPrefix))
                            {
                                ResourceFileId = resourceFileId;
                                IsProvenOrigin = true;
                            }
                            else
                            {
                                ResourceFileId =  ResourceConst.ResourceFileId_EditorialPrefix + Guid.NewGuid();
                                IsProvenOrigin = false;
                            }
                            break;
                        default :
                            ResourceFileId = null;
                            IsProvenOrigin = false;
                            break;
                    }
                }
                else ResourceFileId = null;
            }
            catch (Exception ex)
            {
                //var logger = Startup.ServiceProvider.GetService(typeof(ILogger)) as ILogger;
                //logger.Log(LogType.Error, ex.Message, (new StackTrace(ex, true)).GetFrames().Last());
                //throw;
            }
        }
    }

    public enum ResourceType
    {
        Audio,
        Image,
        Video,
        ThirdParty,
        Editotial
    }
}
