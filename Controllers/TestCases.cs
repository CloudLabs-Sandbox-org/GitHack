//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using CRUD_application_2.Controllers;
//using CRUD_application_2.Models;
//using System.Web.Mvc;
//using System.Collections.Generic;
//using System.Linq;

//namespace CRUD_application_2.Tests.Controllers
//{
//    [TestClass]
//    public class UserControllerTests
//    {
//        private UserController _controller;

//        [TestInitialize]
//        public void Initialize()
//        {
//            // Initialize UserController and clear the userlist before each test
//            UserController.userlist.Clear();
//            _controller = new UserController();
//        }

//        [TestMethod]
//        public void Index_Should_Return_View_With_All_Users()
//        {
//            // Arrange
//            UserController.userlist.Add(new User { Id = 1, Name = "Test User" });

//            // Act
//            var result = _controller.Index() as ViewResult;

//            // Assert
//            Assert.IsNotNull(result);
//            var model = result.Model as List<User>;
//            Assert.AreEqual(1, model.Count);
//        }

//        [TestMethod]
//        public void Details_Should_Return_User_By_Id()
//        {
//            // Arrange
//            UserController.userlist.Add(new User { Id = 1, Name = "Test User" });

//            // Act
//            var result = _controller.Details(1) as ViewResult;

//            // Assert
//            Assert.IsNotNull(result);
//            var model = result.Model as User;
//            Assert.AreEqual(1, model.Id);
//        }

//        [TestMethod]
//        public void Create_Post_Should_Add_User()
//        {
//            // Arrange
//            var user = new User { Id = 2, Name = "New User" };

//            // Act
//            var result = _controller.Create(user) as RedirectToRouteResult;

//            // Assert
//            Assert.IsNotNull(result);
//            Assert.AreEqual("Index", result.RouteValues["action"]);
//            Assert.AreEqual(1, UserController.userlist.Count);
//            Assert.AreEqual("New User", UserController.userlist.First().Name);
//        }

//        [TestMethod]
//        public void Edit_Get_Should_Return_User_By_Id()
//        {
//            // Arrange
//            UserController.userlist.Add(new User { Id = 1, Name = "Test User" });

//            // Act
//            var result = _controller.Edit(1) as ViewResult;

//            // Assert
//            Assert.IsNotNull(result);
//            var model = result.Model as User;
//            Assert.AreEqual(1, model.Id);
//        }

//        [TestMethod]
//        public void Edit_Post_Should_Update_User()
//        {
//            // Arrange
//            UserController.userlist.Add(new User { Id = 1, Name = "Test User" });
//            var updatedUser = new User { Id = 1, Name = "Updated User" };

//            // Act
//            var result = _controller.Edit(1, updatedUser) as RedirectToRouteResult;

//            // Assert
//            Assert.IsNotNull(result);
//            Assert.AreEqual("Index", result.RouteValues["action"]);
//            Assert.AreEqual("Updated User", UserController.userlist.First().Name);
//        }

//        [TestMethod]
//        public void Delete_Get_Should_Return_User_By_Id()
//        {
//            // Arrange
//            UserController.userlist.Add(new User { Id = 1, Name = "Test User" });

//            // Act
//            var result = _controller.Delete(1) as ViewResult;

//            // Assert
//            Assert.IsNotNull(result);
//            var model = result.Model as User;
//            Assert.AreEqual(1, model.Id);
//        }

//        [TestMethod]
//        public void Delete_Post_Should_Remove_User()
//        {
//            // Arrange
//            UserController.userlist.Add(new User { Id = 1, Name = "Test User" });

//            // Act
//            var result = _controller.DeleteConfirmed(1) as RedirectToRouteResult;

//            // Assert
//            Assert.IsNotNull(result);
//            Assert.AreEqual("Index", result.RouteValues["action"]);
//            Assert.IsFalse(UserController.userlist.Any(u => u.Id == 1));
//        }
//    }
//}


using Microsoft.VisualStudio.TestTools.UnitTesting;
using CRUD_application_2.Controllers;
using CRUD_application_2.Models;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CRUD_application_2.Tests.Controllers
{
    [TestClass]
    public class UserControllerTests
    {
        private UserController _controller;

        [TestInitialize]
        public void Initialize()
        {
            // Initialize UserController and clear the userlist before each test
            UserController.userlist.Clear();
            _controller = new UserController();
        }

        [TestMethod]
        public void Index_Should_Return_View_With_All_Users()
        {
            // Arrange
            UserController.userlist.Add(new User { Id = 1, Name = "Test User" });

            // Act
            var result = _controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            var model = result.Model as List<User>;
            Assert.AreEqual(1, model.Count);
        }

        [TestMethod]
        public void Details_Should_Return_User_By_Id()
        {
            // Arrange
            UserController.userlist.Add(new User { Id = 1, Name = "Test User" });

            // Act
            var result = _controller.Details(1) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            var model = result.Model as User;
            Assert.AreEqual(1, model.Id);
        }

        [TestMethod]
        public void Create_Post_Should_Add_User()
        {
            // Arrange
            var user = new User { Id = 2, Name = "New User" };

            // Act
            var result = _controller.Create(user) as RedirectToRouteResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Index", result.RouteValues["action"]);
            Assert.AreEqual(1, UserController.userlist.Count);
            Assert.AreEqual("New User", UserController.userlist.First().Name);
        }

        [TestMethod]
        public void Edit_Get_Should_Return_User_By_Id()
        {
            // Arrange
            UserController.userlist.Add(new User { Id = 1, Name = "Test User" });

            // Act
            var result = _controller.Edit(1) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            var model = result.Model as User;
            Assert.AreEqual(1, model.Id);
        }

        [TestMethod]
        public void Edit_Post_Should_Update_User()
        {
            // Arrange
            UserController.userlist.Add(new User { Id = 1, Name = "Test User" });
            var updatedUser = new User { Id = 1, Name = "Updated User" };

            // Act
            var result = _controller.Edit(1, updatedUser) as RedirectToRouteResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Index", result.RouteValues["action"]);
            Assert.AreEqual("Updated User", UserController.userlist.First().Name);
        }

        [TestMethod]
        public void Delete_Get_Should_Return_User_By_Id()
        {
            // Arrange
            UserController.userlist.Add(new User { Id = 1, Name = "Test User" });

            // Act
            var result = _controller.Delete(1) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            var model = result.Model as User;
            Assert.AreEqual(1, model.Id);
        }

        [TestMethod]
        public void Delete_Post_Should_Remove_User()
        {
            // Arrange
            UserController.userlist.Add(new User { Id = 1, Name = "Test User" });

            // Assuming your UserController uses Delete(int id) for the POST action
            // Adjust this part if your controller uses a different method for POST delete
            var formCollection = new FormCollection();
            _controller.ValueProvider = formCollection.ToValueProvider();

            // Act
            var result = _controller.Delete(1, formCollection) as RedirectToRouteResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Index", result.RouteValues["action"]);
            Assert.IsFalse(UserController.userlist.Any(u => u.Id == 1));
        }
        [TestMethod]
        public void Index_Should_Filter_Users_By_SearchName()
        {
            // Arrange
            UserController.userlist.Add(new User { Id = 1, Name = "Alice" });
            UserController.userlist.Add(new User { Id = 2, Name = "Bob" });
            UserController.userlist.Add(new User { Id = 3, Name = "Charlie" });
            _controller = new UserController();

            // Act
            var result = _controller.Index("Bob") as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            var model = result.Model as List<User>;
            Assert.AreEqual(1, model.Count); // Expecting only 1 user to match the search
            Assert.AreEqual("Bob", model.First().Name);
        }
    }
}
