using System;
namespace QuickAd.Models {
	public class Comment {
		public int Id;
		public String Hash;
		public String Title;
		public String Content;
		public DateTime CreatedAt;

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
		public String GetTitle() {
			return this.Title;
		}
		public void SetTitle(String title) {
			this.Title = title;
		}
		public String GetContent() {
			return this.Content;
		}
		public void SetContent(String content) {
			this.Content = content;
		}
		public DateTime GetCreatedAt() {
			return this.CreatedAt;
		}
		public void SetCreatedAt(DateTime createdAt) {
			this.CreatedAt = createdAt;
		}


	}

}
