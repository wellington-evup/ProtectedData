using NUnit.Framework;
using ProtectedData.Core;
using ProtectedData.Core.Enums;
using ProtectedData.Core.ExtensionMethods;
using System.Linq;

namespace ProtectedData.UnitTest
{
    public class Tests
    {
        SensitiveDataManager sensitiveDataManager;

        [OneTimeSetUp]
        public void Setup()
        {
            sensitiveDataManager = new SensitiveDataManager(new BlockedEmail[0], new BlockedPhone[0]);
        }

        [Test]
        public void IsAbleToAccessAddress_TypePersonal()
        {
            //Arrange
            var loggedUser = new User() { Profile = new UserProfile() { SensitiveDataTypes = new[] { ESensitiveDataType.Personal }.ToList() } };
            bool actual, expected = false;

            //Act
            actual = sensitiveDataManager.IsAbleToAccessAddress(loggedUser);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsAbleToAccessAddress_TypeIdentification()
        {
            //Arrange
            var loggedUser = new User() { Profile = new UserProfile() { SensitiveDataTypes = new[] { ESensitiveDataType.Identification }.ToList() } };
            bool actual, expected = false;

            //Act
            actual = sensitiveDataManager.IsAbleToAccessAddress(loggedUser);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsAbleToAccessAddress_TypeContact()
        {
            //Arrange
            var loggedUser = new User() { Profile = new UserProfile() { SensitiveDataTypes = new[] { ESensitiveDataType.Contact }.ToList() } };
            bool actual, expected = true;

            //Act
            actual = sensitiveDataManager.IsAbleToAccessAddress(loggedUser);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsAbleToAccessBirthDate_TypePersonal()
        {
            //Arrange
            var loggedUser = new User() { Profile = new UserProfile() { SensitiveDataTypes = new[] { ESensitiveDataType.Personal }.ToList() } };
            bool actual, expected = false;

            //Act
            actual = sensitiveDataManager.IsAbleToAccessBirthDate(loggedUser);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsAbleToAccessBirthDate_TypeIdentification()
        {
            //Arrange
            var loggedUser = new User() { Profile = new UserProfile() { SensitiveDataTypes = new[] { ESensitiveDataType.Identification }.ToList() } };
            bool actual, expected = true;

            //Act
            actual = sensitiveDataManager.IsAbleToAccessBirthDate(loggedUser);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsAbleToAccessBirthDate_TypeContact()
        {
            //Arrange
            var loggedUser = new User() { Profile = new UserProfile() { SensitiveDataTypes = new[] { ESensitiveDataType.Contact }.ToList() } };
            bool actual, expected = false;

            //Act
            actual = sensitiveDataManager.IsAbleToAccessBirthDate(loggedUser);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsAbleToAccessCPF_TypePersonal()
        {
            //Arrange
            var loggedUser = new User() { Profile = new UserProfile() { SensitiveDataTypes = new[] { ESensitiveDataType.Personal }.ToList() } };
            bool actual, expected = false;

            //Act
            actual = sensitiveDataManager.IsAbleToAccessCPF(loggedUser);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsAbleToAccessCPF_TypeIdentification()
        {
            //Arrange
            var loggedUser = new User() { Profile = new UserProfile() { SensitiveDataTypes = new[] { ESensitiveDataType.Identification }.ToList() } };
            bool actual, expected = true;

            //Act
            actual = sensitiveDataManager.IsAbleToAccessCPF(loggedUser);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsAbleToAccessCPF_TypeContact()
        {
            //Arrange
            var loggedUser = new User() { Profile = new UserProfile() { SensitiveDataTypes = new[] { ESensitiveDataType.Contact }.ToList() } };
            bool actual, expected = false;

            //Act
            actual = sensitiveDataManager.IsAbleToAccessCPF(loggedUser);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsAbleToAccessCNPJ_TypePersonal()
        {
            //Arrange
            var loggedUser = new User() { Profile = new UserProfile() { SensitiveDataTypes = new[] { ESensitiveDataType.Personal }.ToList() } };
            bool actual, expected = false;

            //Act
            actual = sensitiveDataManager.IsAbleToAccessCNPJ(loggedUser);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsAbleToAccessCNPJ_TypeIdentification()
        {
            //Arrange
            var loggedUser = new User() { Profile = new UserProfile() { SensitiveDataTypes = new[] { ESensitiveDataType.Identification }.ToList() } };
            bool actual, expected = true;

            //Act
            actual = sensitiveDataManager.IsAbleToAccessCNPJ(loggedUser);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsAbleToAccessCNPJ_TypeContact()
        {
            //Arrange
            var loggedUser = new User() { Profile = new UserProfile() { SensitiveDataTypes = new[] { ESensitiveDataType.Contact }.ToList() } };
            bool actual, expected = false;

            //Act
            actual = sensitiveDataManager.IsAbleToAccessCNPJ(loggedUser);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsAbleToAccessEmail_TypePersonal()
        {
            //Arrange
            var loggedUser = new User() { Profile = new UserProfile() { SensitiveDataTypes = new[] { ESensitiveDataType.Personal }.ToList() } };
            var client = new Client();
            bool actual, expected = false;

            //Act
            actual = sensitiveDataManager.IsAbleToAccessEmail(loggedUser, client);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsAbleToAccessEmail_TypeIdentification()
        {
            //Arrange
            var loggedUser = new User() { Profile = new UserProfile() { SensitiveDataTypes = new[] { ESensitiveDataType.Identification }.ToList() } };
            var client = new Client();
            bool actual, expected = false;

            //Act
            actual = sensitiveDataManager.IsAbleToAccessEmail(loggedUser, client);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsAbleToAccessEmail_TypeContact_NoPermission()
        {
            //Arrange
            var loggedUser = new User() { Profile = new UserProfile() { SensitiveDataTypes = new[] { ESensitiveDataType.Contact }.ToList() } };
            var client = new Client() { ContactPermission = new ContactPermission() { ByEmail = false } };
            bool actual, expected = false;

            //Act
            actual = sensitiveDataManager.IsAbleToAccessEmail(loggedUser, client);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsAbleToAccessEmail_TypeContact_WithPermission_InBlocklist()
        {
            //Arrange
            var loggedUser = new User() { Profile = new UserProfile() { SensitiveDataTypes = new[] { ESensitiveDataType.Contact }.ToList() } };
            var email = new Email("wellingtonalves624@gmail.com");
            var client = new Client() { ContactPermission = new ContactPermission() { ByEmail = true }, Email = email };
            var sdmanager = new SensitiveDataManager(new[] { new BlockedEmail() { Email = email } }, null);
            bool actual, expected = false;

            //Act
            actual = sdmanager.IsAbleToAccessEmail(loggedUser, client);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsAbleToAccessPhone_TypePersonal()
        {
            //Arrange
            var loggedUser = new User() { Profile = new UserProfile() { SensitiveDataTypes = new[] { ESensitiveDataType.Personal }.ToList() } };
            var client = new Client();
            bool actual, expected = false;

            //Act
            actual = sensitiveDataManager.IsAbleToAccessPhone(loggedUser, client);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsAbleToAccessPhone_TypeIdentification()
        {
            //Arrange
            var loggedUser = new User() { Profile = new UserProfile() { SensitiveDataTypes = new[] { ESensitiveDataType.Identification }.ToList() } };
            var client = new Client();
            bool actual, expected = false;

            //Act
            actual = sensitiveDataManager.IsAbleToAccessPhone(loggedUser, client);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsAbleToAccessPhone_TypeContact_NoPermission()
        {
            //Arrange
            var loggedUser = new User() { Profile = new UserProfile() { SensitiveDataTypes = new[] { ESensitiveDataType.Contact }.ToList() } };
            var client = new Client() { ContactPermission = new ContactPermission() { ByPhone = false } };
            bool actual, expected = false;

            //Act
            actual = sensitiveDataManager.IsAbleToAccessPhone(loggedUser, client);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsAbleToAccessPhone_TypeContact_WithPermission_InBlocklist()
        {
            //Arrange
            var loggedUser = new User() { Profile = new UserProfile() { SensitiveDataTypes = new[] { ESensitiveDataType.Contact }.ToList() } };
            var Phone = new Phone(11, 99999999);
            var client = new Client() { ContactPermission = new ContactPermission() { ByPhone = true }, Phone = Phone };
            var sdmanager = new SensitiveDataManager(null, new[] { new BlockedPhone() { Phone = Phone } });
            bool actual, expected = false;

            //Act
            actual = sdmanager.IsAbleToAccessPhone(loggedUser, client);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsAbleToAccessRG_TypePersonal()
        {
            //Arrange
            var loggedUser = new User() { Profile = new UserProfile() { SensitiveDataTypes = new[] { ESensitiveDataType.Personal }.ToList() } };
            bool actual, expected = false;

            //Act
            actual = sensitiveDataManager.IsAbleToAccessRG(loggedUser);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsAbleToAccessRG_TypeIdentification()
        {
            //Arrange
            var loggedUser = new User() { Profile = new UserProfile() { SensitiveDataTypes = new[] { ESensitiveDataType.Identification }.ToList() } };
            bool actual, expected = true;

            //Act
            actual = sensitiveDataManager.IsAbleToAccessRG(loggedUser);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsAbleToAccessRG_TypeContact()
        {
            //Arrange
            var loggedUser = new User() { Profile = new UserProfile() { SensitiveDataTypes = new[] { ESensitiveDataType.Contact }.ToList() } };
            bool actual, expected = false;

            //Act
            actual = sensitiveDataManager.IsAbleToAccessRG(loggedUser);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}