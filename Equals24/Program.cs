using NUnit.Framework;

Assert.AreEqual(equalTo24(1, 2, 3, 4), "24");
Assert.AreEqual(equalTo24(2, 3, 4, 5), "24");
Assert.AreEqual(equalTo24(3, 4, 5, 6), "24");
Assert.AreEqual(equalTo24(1, 1, 1, 13), "It's not possible!");
Assert.AreEqual(equalTo24(13, 13, 6, 12), "It's not possible!");
Assert.AreEqual(equalTo24(2, 7, 7, 13), "It's not possible!");
Assert.AreEqual(equalTo24(4, 3, 1, 6), "24");
Assert.AreEqual(equalTo24(1, 1, 1, 1), "It's not possible!");
Assert.AreEqual(equalTo24(13, 13, 13, 13), "It's not possible!");

string equalTo24(int a, int b, int c, int d)
{
    return "It's not possible!";
}