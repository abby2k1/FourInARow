namespace Team9.Connect4.WebUI.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LoadTest()
        {
            BingoController controller = new BingoController();
            var results = controller.Index() as ViewResult;
            var list = results.Model as List<BL.Models.Color>;
            Assert.AreEqual(3, list.Count);
        }

        [TestMethod]
        public void InsertTest()
        {
            BingoController controller = new BingoController();
            BL.Models.Color color = new BL.Models.Color { Code = 333333, Description = "Test" };
            var results = controller.Create(color, true) as RedirectToActionResult;
            Assert.AreEqual("Index", results.ActionName);
        }
    }
}