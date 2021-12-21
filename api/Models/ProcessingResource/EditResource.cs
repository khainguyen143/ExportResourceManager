using System.Collections.Generic;

namespace ExportVideoManager.Models.ProcessingResource
{
    public class EditResource
    {
        public string EditorialId { get; set; }
        public Editorial Editorial { get; set; }

        public string ResourcesId { get; set; }
        public Resources Resources { get; set; }

        public string Title { get; set; }   //có thể tên file khác nhau nhưng resourceFileId là một nên tên file lưu ở đây
        public long StartTime { get; set; } //thời gian bắt đầu trong 1 video và kết thúc
        public long EndTime { get; set; }   //thời gian bắt đầu trong 1 video và kết thúc


    }
}
