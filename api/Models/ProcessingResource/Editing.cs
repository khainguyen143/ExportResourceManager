using API.Constants;
using API.Models;
using API.Models.Authorization;
using System;
using System.Collections.Generic;

namespace ExportVideoManager.Models.ProcessingResource
{
    public class Editing : BaseModel, ISoftDeletableModel, ILoggableUserActionModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ResourceFileId { get; set; }   // Mã riêng cho loại đã biên tập
        public string EditingSoftware { get; set; }  // phần mềm chỉnh sửa
        public List<string> UsedByUrls { get; set; } // sau này sẽ check theo url để lấy tên file trên youtube nếu resourceFileId == ResourceFileId thì lưu url lại để tiện sau này truy xuất nguồn gốc bằng url 
        public ResourceType ResourceType { get; set; } 
        public List<ResourceEditorial> ResourceEditorials { get; set; }

        //------------------------------------------
        public string CreatedByUserId { get; set; }
        public User CreatedByUser { get; set; }
        public string UpdatedByUserId { get; set; }
        public User UpdatedByUser { get; set; }
        public string DeletedByUserId { get; set; }
        public User DeletedByUser { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }

        public void SetResourceFileId()
        {
            try
            {
                ResourceFileId = ResourceConst.ResourceFileId_EditorialPrefix + Guid.NewGuid();
            }
            catch (Exception ex)
            {
                //var logger = Startup.ServiceProvider.GetService(typeof(ILogger)) as ILogger;
                //logger.Log(LogType.Error, ex.Message, (new StackTrace(ex, true)).GetFrames().Last());
                //throw;
            }
        }
    }
}
