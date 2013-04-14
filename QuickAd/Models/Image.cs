using System;
namespace QuickAd.Models {
	public class Image {
		public String ImagePath;
		public int Id;
		public String Hash;
		public String Extension;

		public void GetImagePath() {
			return this.ImagePath;
		}
		public void SetImagePath(object imagePath) {
			this.ImagePath = imagePath;
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
		public String GetExtension() {
			return this.Extension;
		}
		public void SetExtension(String extension) {
			this.Extension = extension;
		}


	}

}
