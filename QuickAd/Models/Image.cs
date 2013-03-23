using System;
namespace QuickAd.Models
{
	public class Image {
		private String imagePath;
		private String hash;
		private int id;
		private String extension;
		private bool isPrivate;

		public String GetImagePath() {
			return this.imagePath;
		}
		public void SetImagePath(String imagePath) {
			this.imagePath = imagePath;
		}
		public String GetHash() {
			return this.hash;
		}
		public void SetHash(String hash) {
			this.hash = hash;
		}
		public int GetId() {
			return this.id;
		}
		public void SetId(int id) {
			this.id = id;
		}
		public String GetExtension() {
			return this.extension;
		}
		public void SetExtension(String extension) {
			this.extension = extension;
		}
		public bool GetIsPrivate() {
			return this.isPrivate;
		}
		public void SetIsPrivate(bool isPrivate) {
			this.isPrivate = isPrivate;
		}


	}

}
