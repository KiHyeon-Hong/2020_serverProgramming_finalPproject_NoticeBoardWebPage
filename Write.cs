using System;

namespace _201533892NoticeBoard
{
    public class Write
    {
        private int writeId;
        private string title;
        private string body;
        private DateTime createDay;
        private DateTime updateDay;
        private int userId;

        public Write(int writeId, string title, string body, DateTime createDay, DateTime updateDay, int userId)
        {
            this.writeId = writeId;
            this.title = title;
            this.body = body;
            this.createDay = createDay;
            this.updateDay = updateDay;
            this.userId = userId;
        }
        public int getWriteId()
        {
            return writeId;
        }
        public void setWriteId(int writeId)
        {
            this.writeId = writeId;
        }
        public string getTitle()
        {
            return title;
        }
        public void setTitle(string title)
        {
            this.title = title;
        }
        public string getBody()
        {
            return body;
        }
        public void setBody(string body)
        {
            this.body = body;
        }
        public DateTime getCreateDay()
        {
            return createDay;
        }
        public void setCreateDay(DateTime createDay)
        {
            this.createDay = createDay;
        }
        public DateTime getUpdateDay()
        {
            return updateDay;
        }
        public void setUpdateDay(DateTime updateDay)
        {
            this.updateDay = updateDay;
        }
        public int getUserId()
        {
            return userId;
        }
        public void setUserId(int userId)
        {
            this.userId = userId;
        }
        public string printWrite()
        {
            return "writeId :" + writeId + ", title :" + title + ", body :" + body + ", createDay :" + createDay + ", updateDay :" + updateDay + ", userId :" + userId;
        }
    }
}