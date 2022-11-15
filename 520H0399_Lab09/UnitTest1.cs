using StudentServiceLib;

namespace _520H0399_Lab09
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IfScoreIs8_TheRankShouldBeA()
        {
            Student student = new Student();
            student.Score = 8;

            char letter = student.getLetterScore();
            Assert.AreEqual('A', letter) ;
        }
        [TestMethod]
        public void IfScoreIs9_TheRankShouldBeA()
        {
            Student student = new Student();
            student.Score = 9;

            char letter = student.getLetterScore();
            Assert.AreEqual('A', letter);
        }
        [TestMethod]
        public void IfScoreIs7_TheRankShouldBeB()
        {
            Student student = new Student();
            student.Score = 7;

            char letter = student.getLetterScore();
            Assert.AreEqual('B', letter);
        }
        [TestMethod]
        public void IfScoreIs6dot5_TheRankShouldBeC()
        {
            Student student = new Student();
            student.Score = 6.5;

            char letter = student.getLetterScore();
            Assert.AreEqual('C', letter);
        }
        [TestMethod]
        public void IfScoreIs4_TheRankShouldBeD()
        {
            Student student = new Student();
            student.Score = 4;

            char letter = student.getLetterScore();
            Assert.AreEqual('D', letter);
        }
        [TestMethod]
        public void IfScoreIs1_TheRankShouldBeE()
        {
            Student student = new Student();
            student.Score = 1;

            char letter = student.getLetterScore();
            Assert.AreEqual('E', letter);
        }
    }
}