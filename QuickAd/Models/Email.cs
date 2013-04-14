using System;
namespace QuickAd.Models 
{
	public class Email 
    {
        private User SenderUser;
        private String Content;
        private String Title;
        private DateTime DateSend;
        private bool IsSend;
        private int Id;
        private String Hash;
        private DateTime DateCreated;
        private int IdSender;
        private int IdRecipent;

        #region ORM Properties

        public virtual int Vid {get { return this.Id; } set { this.Id = value; }}
        public virtual int VidSenderUser {get { return this.IdSender; } set { this.IdSender = value; }}
        public virtual int VidRecipent {get { return this.IdRecipent; } set { this.IdRecipent = value; }}
        public virtual string Vcontent {get { return this.Content; } set { this.Content = value; }}
        public virtual string Vtitle {get { return this.Title; } set { this.Title = value; }}
        public virtual DateTime VsendDate {get { return this.DateSend; } set { this.DateSend = value; }}
        public virtual bool VisSend {get { return this.IsSend; } set {this.IsSend = value;}}
        public virtual DateTime VcreatedDate {get { return this.DateCreated; } set { this.DateCreated = value; }}

        #endregion

        #region Properties

        public User GetSenderUser() {return this.SenderUser;}
	    public void SetSenderUser(User senderUser) {this.SenderUser = senderUser;}

	    public String GetContent() {return this.Content;}
		public void SetContent(String content) {this.Content = content;}

		public String GetTitle() {return this.Title;}
		public void SetTitle(String title) {this.Title = title;}

		public DateTime GetDateSend() {return this.DateSend;}
		public void SetDateSend(DateTime dateSend) {this.DateSend = dateSend;}

		public bool GetIsSend() {return this.IsSend;}
		public void SetIsSend(bool isSend) {this.IsSend = isSend;}

		public int GetId() {return this.Id;}
		public void SetId(int id) {this.Id = id;}

		public String GetHash() {return this.Hash;}
		public void SetHash(String hash) {this.Hash = hash;}

		public DateTime GetDateCreated() {return this.DateCreated;}
		public void SetDateCreated(DateTime dateCreated) {this.DateCreated = dateCreated;}

        #endregion
    }
}
