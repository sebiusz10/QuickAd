using System;
namespace QuickAd.Models
{
	public class Email {
		private User senderUser;
		private String content;
		private String titleString;
		private DateTime dateSend;
		private bool isSend;
		private int id;
		private String hash;
		private DateTime dateCreated;

		public User GetSenderUser() {
			return this.senderUser;
		}
		public void SetSenderUser(User senderUser) {
			this.senderUser = senderUser;
		}
		public String GetContent() {
			return this.content;
		}
		public void SetContent(String content) {
			this.content = content;
		}
		public String GetTitleString() {
			return this.titleString;
		}
		public void SetTitleString(String titleString) {
			this.titleString = titleString;
		}
		public DateTime GetDateSend() {
			return this.dateSend;
		}
		public void SetDateSend(DateTime dateSend) {
			this.dateSend = dateSend;
		}
		public bool GetIsSend() {
			return this.isSend;
		}
		public void SetIsSend(bool isSend) {
			this.isSend = isSend;
		}
		public Email(User recivier) {
			throw new System.Exception("Not implemented");
		}
		public int GetId() {
			return this.id;
		}
		public void SetId(int id) {
			this.id = id;
		}
		public String GetHash() {
			return this.hash;
		}
		public void SetHash(String hash) {
			this.hash = hash;
		}
		public void GetAttribute() {
			throw new System.Exception("Not implemented");
		}
		public void SetAttribute(object attribute) {
			throw new System.Exception("Not implemented");
		}
		public DateTime GetDateCreated() {
			return this.dateCreated;
		}
		public void SetDateCreated(DateTime dateCreated) {
			this.dateCreated = dateCreated;
		}


	}

}
