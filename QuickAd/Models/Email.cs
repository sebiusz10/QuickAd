using System;
namespace QuickAd.Models {
	public class Email {
		public User SenderUser;
		public String Content;
		public String Title;
		public DateTime DateSend;
		public bool IsSend;
		public int Id;
		public String Hash;
		public DateTime DateCreated;

		public User GetSenderUser() {
			return this.SenderUser;
		}
		public void SetSenderUser(User senderUser) {
			this.SenderUser = senderUser;
		}
		public String GetContent() {
			return this.Content;
		}
		public void SetContent(String content) {
			this.Content = content;
		}
		public String GetTitle() {
			return this.Title;
		}
		public void SetTitle(String title) {
			this.Title = title;
		}
		public DateTime GetDateSend() {
			return this.DateSend;
		}
		public void SetDateSend(DateTime dateSend) {
			this.DateSend = dateSend;
		}
		public bool GetIsSend() {
			return this.IsSend;
		}
		public void SetIsSend(bool isSend) {
			this.IsSend = isSend;
		}
		public int GetId() {
			return this.Id;
		}
		public void SetId(int id) {
			this.Id = id;
		}
		public String GetHash() {
			return this.Hash;
		}
		public void SetHash(String hash) {
			this.Hash = hash;
		}
		public DateTime GetDateCreated() {
			return this.DateCreated;
		}
		public void SetDateCreated(DateTime dateCreated) {
			this.DateCreated = dateCreated;
		}


	}

}
