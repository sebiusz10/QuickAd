using System;
namespace Schemat obiektów logicznych {
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
		public void SetSenderUser(out User senderUser) {
			this.senderUser = senderUser;
		}
		public String GetContent() {
			return this.content;
		}
		public void SetContent(out String content) {
			this.content = content;
		}
		public String GetTitleString() {
			return this.titleString;
		}
		public void SetTitleString(out String titleString) {
			this.titleString = titleString;
		}
		public DateTime GetDateSend() {
			return this.dateSend;
		}
		public void SetDateSend(out DateTime dateSend) {
			this.dateSend = dateSend;
		}
		public bool GetIsSend() {
			return this.isSend;
		}
		public void SetIsSend(out bool isSend) {
			this.isSend = isSend;
		}
		public Email(out User recivier) {
			throw new System.Exception("Not implemented");
		}
		public int GetId() {
			return this.id;
		}
		public void SetId(out int id) {
			this.id = id;
		}
		public String GetHash() {
			return this.hash;
		}
		public void SetHash(out String hash) {
			this.hash = hash;
		}
		public void GetAttribute() {
			throw new System.Exception("Not implemented");
		}
		public void SetAttribute(out object attribute) {
			throw new System.Exception("Not implemented");
		}
		public DateTime GetDateCreated() {
			return this.dateCreated;
		}
		public void SetDateCreated(out DateTime dateCreated) {
			this.dateCreated = dateCreated;
		}


	}

}
