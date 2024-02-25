using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class UnitTestModel
{
    [TestMethod]
    public void TestInputData()
    {
        // Arrange
        Matrix matrix = new Matrix(2, 2);

        // Act
        matrix.InputData();

        // Assert 
        Assert.IsNotNull(matrix); 
    }

    [TestMethod]
    public void TestFindMax()
    {
        // Arrange
        Matrix matrix = new Matrix(2, 2);
        matrix.InputData();

        // Act
        int max = matrix.FindMax();

        // Assert
        Assert.AreEqual(4, max); 
    }

    [TestMethod]
    public void TestFindMin()
    {
        // Arrange
        Matrix matrix = new Matrix(2, 2);
        matrix.InputData();

        // Act
        int min = matrix.FindMin();

        // Assert
        Assert.AreEqual(1, min); 
    }
}
