// Purpose: Tests for the Triangle class.
namespace ShapeTests;

[TestFixture]
public class TriangleTests
{
    [Test]
    public void GetArea_ReturnsRightResult()
    {
        //Arrange
        var triangle1 = new Triangle( 28, 26, 30);
        var triangle2 = new Triangle(4, 5, 3);
        
        //Act & Assert
        Assert.AreEqual( 336, triangle1.GetArea());
        Assert.AreEqual( 6, triangle2.GetArea());
    }
    
    [Test]
    public void IsRightTriangle_ReturnsRightResult()
    {
        //Arrange
        var triangle = new Triangle( 28, 26, 30);
        var rightTriangle = new Triangle(4, 5, 3);
        
        //Act & Assert
        Assert.AreEqual( false, triangle.IsRightTriangle());
        Assert.AreEqual( true, rightTriangle.IsRightTriangle());
    }
}