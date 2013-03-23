using System;
namespace QuickAd.Models
{
	public class User {
		private String firstName;
		private String lastName;
		private String email;
		private DateTime dateOfBirth;
		private String city;
		private String street;
		private int buildingNumber;
		private int homeNumber;
		private int sex;
		private String password;
		private String phoneNumber;
		private int id;
		private String hash;
		private int privillage;

		public String GetFirstName() {
			return this.firstName;
		}
		public void SetFirstName(String firstName) {
			this.firstName = firstName;
		}
		public String GetLastName() {
			return this.lastName;
		}
		public void SetLastName(String lastName) {
			this.lastName = lastName;
		}
		public String GetEmail() {
			return this.email;
		}
		public void SetEmail(String email) {
			this.email = email;
		}
		public DateTime GetDateOfBirth() {
			return this.dateOfBirth;
		}
		public void SetDateOfBirth(DateTime dateOfBirth) {
			this.dateOfBirth = dateOfBirth;
		}
		public String GetCity() {
			return this.city;
		}
		public void SetCity(String city) {
			this.city = city;
		}
		public String GetStreet() {
			return this.street;
		}
		public void SetStreet(String street) {
			this.street = street;
		}
		public int GetBuildingNumber() {
			return this.buildingNumber;
		}
		public void SetBuildingNumber(int buildingNumber) {
			this.buildingNumber = buildingNumber;
		}
		public int GetHomeNumber() {
			return this.homeNumber;
		}
		public void SetHomeNumber(int homeNumber) {
			this.homeNumber = homeNumber;
		}
		public int GetSex() {
			return this.sex;
		}
		public void SetSex(int sex) {
			this.sex = sex;
		}
		public String GetPassword() {
			return this.password;
		}
		public void SetPassword(String password) {
			this.password = password;
		}
		public String GetPhoneNumber() {
			return this.phoneNumber;
		}
		public void SetPhoneNumber(String phoneNumber) {
			this.phoneNumber = phoneNumber;
		}
		public void GetAttribute() {
			throw new System.Exception("Not implemented");
		}
		public void SetAttribute(object attribute) {
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
		public int GetPrivillage() {
			return this.privillage;
		}
		public void SetPrivillage(int privillage) {
			this.privillage = privillage;
		}
		public bool IsAdmin() {
			throw new System.Exception("Not implemented");
		}
		public void IsOwner(Advertise adv) {
			throw new System.Exception("Not implemented");
		}

	}

}
