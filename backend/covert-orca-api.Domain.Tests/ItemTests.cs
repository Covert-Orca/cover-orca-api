using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace covert_orca_api.Domain.Tests
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]


        public void Can_Create_New_Item()
        {
            //Arrange
            var item = new Item(1, "Name", "Description", "Brand", 10.00m);

            //Assert
            Assert.AreEqual("Name", item.Name);
            Assert.AreEqual("Description", item.Description);
            Assert.AreEqual("Brand", item.Brand);
            Assert.AreEqual(10.00m, item.Price);
        }

        public void Can_Create_Add_Rating()
        { 
            //Arrange
            var item = new Item("Name", "Description", "Brand", 10.00m);
            var rating = new Rating(5, "Name", "Review");

            //Act
            item.AddRating(rating);

            //Assert
            Assert.AreEqual(rating, item.Rating[0]);
        }
    }
}
