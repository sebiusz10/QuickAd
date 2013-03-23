using System;
namespace QuickAd.Models
{
	public class Comment {
		private int id;
		private String hash;
		private String title;
		private String content;
		private DateTime createdAt;

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
		public String GetTitle() {
			return this.title;
		}
		public void SetTitle(String title) {
			this.title = title;
		}
		public String GetContent() {
			return this.content;
		}
		public void SetContent(String content) {
			this.content = content;
		}
		public DateTime GetCreatedAt() {
			return this.createdAt;
		}
		public void SetCreatedAt(DateTime createdAt) {
			this.createdAt = createdAt;
		}

		private Advertise advertise;

	}

}
